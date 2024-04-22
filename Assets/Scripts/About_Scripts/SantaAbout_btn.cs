using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaAbout_btn : MonoBehaviour
{
    private void Awake()
    {
        //Normal AudioManager
        AudioManager.instance.StopPlaying("MainMenu_Music");
        AudioManager.instance.StopPlaying("Music");
        AudioManager.instance.StopPlaying("Street_Music");
        AudioManager.instance.StopPlaying("About_Music");

        Time.timeScale = 1f;

        //Santa AudioManager
        AudioManager.instance.StopPlaying("SantaMainMenu_Music");
        AudioManager.instance.StopPlaying("Santa_Music");
        AudioManager.instance.StopPlaying("SantaStreet_Music");
        AudioManager.instance.Play("SantaAbout_Music");
        AudioManager.instance.Play("Picked_Correct");
    }


    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.Play("Picked_Correct");
        AudioManager.instance.StopPlaying("SantaAbout_Music");
    }



}//Class
