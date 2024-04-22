using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Street_Controller_1 : MonoBehaviour
{
    public Button level2_btn;
    public Button level3_btn;

    public GameObject LockedImage_2;
    public GameObject LockedImage_3;


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
        LockedLevel2();
        LockedLevel3();
    }

    public void LockedLevel2()
    {
        if(ScoreTextScript.coinAmount <= 49)
        {
            LockedImage_2.SetActive(true);
            level2_btn.interactable = false;
           // print("You can't open this level now");
        } else
        {
            LockedImage_2.SetActive(false);
            level2_btn.interactable = true;
          //  print("Bravo! You unlocked the level");
        }
    }

    public void LockedLevel3()
    {
        if(ScoreTextScript.coinAmount <= 99)
        {
            LockedImage_3.SetActive(true);
            level3_btn.interactable = false;
           // print("You can't open this level now");
        } else
        {
            LockedImage_3.SetActive(false);
            level3_btn.interactable = true;
           // print("Bravo! You unlocked the level");
        }

    }
    

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel1()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level1");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel2()
    {

        Time.timeScale = 1f;

        SceneManager.LoadScene("Level2");
        AudioManager.instance.Play("Picked_Correct");
    }

    public void LoadLevel3()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("Level3");
        AudioManager.instance.Play("Picked_Correct");
    }





} // class
