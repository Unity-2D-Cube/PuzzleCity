using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Street_Controller_2 : MonoBehaviour
{
    public Button Level4_btn;
    public Button Level5_btn;
    public Button Level6_btn;

    public GameObject LockedImage_5;
    public GameObject LockedImage_6;

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
        LockedLevel4();
        LockedLevel5();
        LockedLevel6();
    }

    public void LockedLevel4()
    {
        if(ScoreTextScript.coinAmount <= 179)
        {
            Level4_btn.interactable = true;
           // print("Welecome to the new Level & Street!");
        }
    }

    public void LockedLevel5()
    {
        if(ScoreTextScript.coinAmount <= 299)
        {
            LockedImage_5.SetActive(true);
            Level5_btn.interactable = false;
           // print("You can't play this level now!");
        } else
        {
            LockedImage_5.SetActive(false);
            Level5_btn.interactable = true;
          //  print("Bravo! You unlocked the new level!");
        }
    }

    public void LockedLevel6()
    {
        if(ScoreTextScript.coinAmount <= 399)
        {
            LockedImage_6.SetActive(true);
            Level6_btn.interactable = false;
          //  print("You can't play this level now!");
        } else
        {
            LockedImage_6.SetActive(false);
            Level6_btn.interactable = true;
          //  print("Bravo! You unlocked the new level!");
        }
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel4()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level4");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel5()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level5");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel6()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level6");
        AudioManager.instance.Play("Picked_Correct");
    }





} // class
