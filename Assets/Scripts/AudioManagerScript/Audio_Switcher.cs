using UnityEngine;
using UnityEngine.UI;

public class Audio_Switcher : MonoBehaviour
{
    [SerializeField]
    private Button On_Button = null;

    [SerializeField]
    private Button Off_Button = null;
  
    private bool AudioON = false;


    private void Start()
    {

        //Off_Audio();
        //On_Audio();

        bool AudioON = PlayerPrefs.GetInt("AudioONstate") == 1 ? true : false;

        if (AudioON == true)
        {
            AudioListener.volume = 1f;
            Off_Button.gameObject.SetActive(false);
            On_Button.gameObject.SetActive(true);
        }
        else if(AudioON == false)
        {
            AudioListener.volume = 0f;
            Off_Button.gameObject.SetActive(true);
            On_Button.gameObject.SetActive(false);
        }
    }

    public void Off_Audio()
    {
        AudioON = false;
        AudioManager.instance.Play("Picked_Correct");

        AudioListener.volume = 0f;

    
        PlayerPrefs.SetInt("AudioONstate", AudioON ? 1 : 0);
        PlayerPrefs.Save();

        Off_Button.gameObject.SetActive(true);
        On_Button.gameObject.SetActive(false);


        
    }

    public void On_Audio()
    {
        AudioON = true;
        AudioManager.instance.Play("Picked_Correct");

        AudioListener.volume = 1f;

        
        PlayerPrefs.SetInt("AudioONstate", AudioON ? 1 : 0);
        PlayerPrefs.Save();


        Off_Button.gameObject.SetActive(false);
        On_Button.gameObject.SetActive(true);


        
    }

}// class
