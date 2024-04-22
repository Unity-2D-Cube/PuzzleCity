using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button Street1_btn;
    public Button Street2_btn;
    public Button Next_City;
    public Button Santa_City;
    public Button About_btn;

    public GameObject LockedImg;
    
    private void Awake()
    {

        Time.timeScale = 1f;
        AudioManager.instance.Play("MainMenu_Music");
        AudioManager.instance.StopPlaying("Music");
        AudioManager.instance.StopPlaying("Street_Music");
        AudioManager.instance.StopPlaying("About_Music");


        AudioManager.instance.StopPlaying("SantaMainMenu_Music");
    }

    private void Start()
    {
        LockedStreet1();
        LockedStreet2();
        LockedSantaCity();
    }

    public void LockedStreet1()
    {
        if (ScoreTextScript.coinAmount <= 0)
        {
            Street1_btn.interactable = true;
           // print("Welcome! To the game!");
        }

    }


    public void LockedStreet2()
    {
        if (ScoreTextScript.coinAmount <= 199)
        {
            LockedImg.SetActive(true);
            Street2_btn.interactable = false;
           // print("You can't open this street now");
        }
        else

        {
            LockedImg.SetActive(false);
            Street2_btn.interactable = true;
          //  print("Bravo! You unlocked the street");
        }
    }

        public void LockedSantaCity()
    {
        if (ScoreTextScript.coinAmount <= 0)
        {
            Santa_City.interactable = true;
           // print("Welcome! To the game!");
        }

    }


    public void LoadStreet_1()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Street_1");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadStreet_2()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Street_2");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadNextCity()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu2");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadSantaCity() 
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("SantaMainMenu_1");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void Load_About_btn()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("About_Scene");
        AudioManager.instance.Play("Picked_Correct");
    }
     
    public void Quit()
    {
        //print("App Quited");
        Application.Quit();
        AudioManager.instance.Play("Picked_Correct");       
    }





} // class
