using UnityEngine;
using UnityEngine.SceneManagement;

public class About_btn : MonoBehaviour
{

    private void Awake()
    {
        //Normal AudioManager
        AudioManager.instance.StopPlaying("MainMenu_Music");
        AudioManager.instance.StopPlaying("Music");
        AudioManager.instance.StopPlaying("Street_Music");
        AudioManager.instance.Play("About_Music");
        AudioManager.instance.Play("Picked_Correct");

        Time.timeScale = 1f;

        //Santa AudioManager
        AudioManager.instance.StopPlaying("SantaMainMenu_Music");
        AudioManager.instance.StopPlaying("Santa_Music");
        AudioManager.instance.StopPlaying("SantaStreet_Music");
        AudioManager.instance.StopPlaying("SantaAbout_Music");
    }


    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.Play("Picked_Correct");
    }

}// class
