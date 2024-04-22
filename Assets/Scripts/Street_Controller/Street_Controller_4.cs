using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Street_Controller_4 : MonoBehaviour
{
    public Button Level10_btn;
    public Button Level11_btn;
    public Button Level12_btn;

    public GameObject Locked_img11;
    public GameObject Locked_img12;



    private void Awake()
    {
        Time.timeScale = 1f;

        AudioManager.instance.Play("Street_Music");
        AudioManager.instance.StopPlaying("Music");
        AudioManager.instance.StopPlaying("MainMenu_Music");


        AudioManager.instance.StopPlaying("SantaMainMenu_Music");
        AudioManager.instance.StopPlaying("Santa_Music");
        AudioManager.instance.StopPlaying("SantaStreet_Music");
        AudioManager.instance.StopPlaying("SantaAbout_Music");
    }

    private void Start()
    {
        LockedLevel11();
        LockedLevel12();


        //   AudioManager.instance.Play("Street_Music");
        //    AudioManager.instance.StopPlaying("Music");
        //     AudioManager.instance.StopPlaying("MainMenu_Music");
    }

    public void LockedLevel11()
    {
        if (ScoreTextScript.coinAmount <= 1199)
        {
            Level11_btn.interactable = false;
            Locked_img11.gameObject.SetActive(true);
        }
        else
        {
            Level11_btn.interactable = true;
            Locked_img11.gameObject.SetActive(false);
        }
    }

    public void LockedLevel12()
    {
        if (ScoreTextScript.coinAmount <= 1999)
        {
            Level12_btn.interactable = false;
            Locked_img12.gameObject.SetActive(true);
        }
        else
        {
            Level12_btn.interactable = true;
            Locked_img12.gameObject.SetActive(false);
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu2");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel10()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level10");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel11()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level11");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel12()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level12");
        AudioManager.instance.Play("Picked_Correct");
    }






}// class
