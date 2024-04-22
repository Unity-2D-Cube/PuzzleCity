using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AD_Manager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidGameId = "4021199";
    [SerializeField] string _iOSGameId = "4021198";
    [SerializeField] bool _testMode = false;
    private string _gameId;

    [SerializeField] Button _showAdButton; //You can remove this if want to add the function manually from OnClick()
    [SerializeField] string _androidAdUnitId = "Rewarded_Android";
    [SerializeField] string _iOSAdUnitId = "Rewarded_iOS";
    string _adUnitId = null; // This will remain null for unsupported platforms

    private bool showAd = false;
    private bool onInitializationFailedToLoad = false;
    private bool onAdFailToLoad = false;
    // private bool networkIsNotActive = false;
    [SerializeField] GameObject errorPanel;
    //    [SerializeField] GameObject errorPanel02;
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject bs01;//bs stands for bullshit
    [SerializeField] GameObject bs02;//ah yes, shit coming with they own parts ......
    [SerializeField] GameObject bs03;//...
    [SerializeField] GameObject bs04;//      . . . 
    [SerializeField] GameObject bs05;//                :|


    void Awake()
    {
        
        InitializeAds();
#if UNITY_EDITOR
        Debug.Log("Awake");
#endif
        _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? _iOSAdUnitId
            : _androidAdUnitId;
#if UNITY_EDITOR
        Debug.Log("the _adUnitId is: " + _adUnitId);
#endif
        LoadAd();

        if (onInitializationFailedToLoad == true || onAdFailToLoad == true)
        {
            LoadAdErrorPanel();
        }
    }


        public void InitializeAds()
        {
            _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
                ? _iOSGameId
                : _androidGameId;
            Advertisement.Initialize(_gameId, _testMode, this);
        }

        public void OnInitializationComplete()
        {

#if UNITY_EDITOR
            Debug.Log("Unity Ads initialization complete.");
#endif
            onInitializationFailedToLoad = false;
            LoadAd();
        }

        public void OnInitializationFailed(UnityAdsInitializationError error, string message)
        {
            onInitializationFailedToLoad = true;
#if UNITY_EDITOR
            Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
#endif
        }

        public void LoadAd()
        {


            // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled on top of the script).
#if UNITY_EDITOR
            Debug.Log("Loading Ad: " + _adUnitId);
#endif
            Advertisement.Load(_adUnitId, this);
        }

        // If the ad successfully loads, add a listener to the button and enable it:
        public void OnUnityAdsAdLoaded(string adUnitId)
        {
#if UNITY_EDITOR
            Debug.Log("Ad Loaded: " + adUnitId);
#endif

            if (adUnitId.Equals(_adUnitId))
            {
                // Configure the button to call the ShowAd() method when clicked:
                _showAdButton.onClick.AddListener(ShowAd); //You can remove this if want to add the function manually from OnClick()
                                                           // Enable the button for users to click:
                _showAdButton.interactable = true; //You can remove this if want to add the function manually from OnClick()
            }
        }

        // Implement a method to execute when the user clicks the button:
        public void ShowAd()
        {


            if (showAd == false)
            {


#if UNITY_EDITOR
                Debug.Log("Showing Ad");
#endif
                // Disable the button:
                _showAdButton.interactable = false; //You can remove this if want to add the function manually from OnClick()
                                                    // Then show the ad:
                Advertisement.Show(_adUnitId, this);
                _showAdButton.onClick.RemoveAllListeners(); //You can remove this if want to add the function manually from OnClick()
#if UNITY_EDITOR
                Debug.Log("All Listeners Removed");
#endif
                showAd = true;

            }
        }

        //Simply don't load AD if onInitializationFailed == true or if onAdFailToLoad == true or if newtwork is not Reachable
        public void LoadAdErrorPanel()
        {


            if (onInitializationFailedToLoad == true || onAdFailToLoad == true)
            {
                mainPanel.SetActive(false);
                bs01.SetActive(false);
                bs02.SetActive(false);
                bs03.SetActive(false);
                bs04.SetActive(false);
                bs05.SetActive(false);
                errorPanel.SetActive(true);

            }
        }

        // Implement the Show Listener's OnUnityAdsShowComplete callback method to determine if the user gets a reward:
        public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
        {
            if (showAd == true)
            {
                if (adUnitId.Equals(_adUnitId) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
                {
#if UNITY_EDITOR
                    Debug.Log("Unity Ads Rewarded Ad Completed");
#endif
                    // Grant a reward.
                    ScoreTextScript.coinAmount += Random.Range(5, 25);
                    // Load another ad:
                    Advertisement.Load(_adUnitId, this);
                    showAd = false;

                }
            }
        }

        public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
        {
#if UNITY_EDITOR
            Debug.Log($"Error loading Ad Unit {adUnitId}: {error.ToString()} - {message}");
#endif
            onAdFailToLoad = true;
            // Use the error details to determine whether to try to load another ad.
        }

        public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
        {
#if UNITY_EDITOR
            Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
#endif
            onAdFailToLoad = true;
            // Use the error details to determine whether to try to load another ad.
        }

        public void OnUnityAdsShowStart(string adUnitId) { }
        public void OnUnityAdsShowClick(string adUnitId) { }



} // Class
