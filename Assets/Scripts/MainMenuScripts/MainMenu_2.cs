using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu_2 : MonoBehaviour
{
    public Button Street_3;
    public Button Street_4;
    public Button MainCitty;

    public GameObject LockedImg;
    public GameObject LockedImg_3;

    private void Awake()
    {
        Time.timeScale = 1f;

        AudioManager.instance.Play("MainMenu_Music");
        AudioManager.instance.StopPlaying("Music");
        AudioManager.instance.StopPlaying("Street_Music");


        AudioManager.instance.StopPlaying("SantaMainMenu_Music");
        AudioManager.instance.StopPlaying("Santa_Music");
        AudioManager.instance.StopPlaying("SantaStreet_Music");
        AudioManager.instance.StopPlaying("SantaAbout_Music");
    }

    private void Start()
    {
        LockedStreet3();
        LockedStreet4();

      //  AudioManager.instance.Play("MainMenu_Music");
      //  AudioManager.instance.StopPlaying("Music");
      //  AudioManager.instance.StopPlaying("Street_Music");
    }

    public void LockedStreet3()
    {
        if(ScoreTextScript.coinAmount <= 599)
        {
            LockedImg_3.SetActive(true);
            Street_3.interactable = false;

        } else
        {
            LockedImg_3.SetActive(false);
            Street_3.interactable = true;
            
        }
    }

    public void LockedStreet4()
    {
        if(ScoreTextScript.coinAmount <= 799)
        {
            LockedImg.SetActive(true);
            Street_4.interactable = false;
        } else
        {
            LockedImg.SetActive(false);
            Street_4.interactable = true;
        }
    }


    public void LoadStreet3()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Street_3");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadStreet4()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Street_4");
        AudioManager.instance.Play("Picked_Correct");
    }



    public void BackToMainCity()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.Play("Picked_Correct");
    }






    public void Exit()
    {
        Application.Quit();
        AudioManager.instance.Play("Picked_Correct");
    }


}// class
