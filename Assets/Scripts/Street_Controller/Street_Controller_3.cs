using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Street_Controller_3 : MonoBehaviour
{
    public Button Level7_btn;
    public Button Level8_btn;
    public Button Level9_btn;

    public GameObject Locked_img8;
    public GameObject Locked_img9;



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
        LockedLevel8();
        LockedLevel9();


     //   AudioManager.instance.Play("Street_Music");
    //    AudioManager.instance.StopPlaying("Music");
   //     AudioManager.instance.StopPlaying("MainMenu_Music");
    }

    public void LockedLevel8()
    {
        if(ScoreTextScript.coinAmount <= 599)
        {
            Level8_btn.interactable = false;
            Locked_img8.gameObject.SetActive(true);
        } else
        {
            Level8_btn.interactable = true;
            Locked_img8.gameObject.SetActive(false);
        }
    }
 
    public void LockedLevel9()
    {
        if(ScoreTextScript.coinAmount <= 799)
        {
            Level9_btn.interactable = false;
            Locked_img9.gameObject.SetActive(true);
        } else
        {
            Level9_btn.interactable = true;
            Locked_img9.gameObject.SetActive(false);
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu2");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel7()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level7");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel8()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level8");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel9()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level9");
        AudioManager.instance.Play("Picked_Correct");
    }



}// class
