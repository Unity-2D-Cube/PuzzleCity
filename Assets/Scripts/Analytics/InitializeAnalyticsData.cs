using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class InitWithDefault : MonoBehaviour
{
    public static InitWithDefault instance;
    async void Awake()
    {
        await UnityServices.InitializeAsync();

        ConsentGiven();
        //AskForConsent();
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    //void AskForConsent()
    //{
    //    // ... show the player a UI element that asks for consent.
    //}

    void ConsentGiven()
    {
#if UNITY_EDITOR
        Debug.LogWarning("Data Collection Started!");
#endif
        AnalyticsService.Instance.StartDataCollection();
    }
}