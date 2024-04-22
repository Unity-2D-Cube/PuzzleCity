using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SantaMainMenu_1 : MonoBehaviour
{
    public Button MainCity;
    public Button NextCity;
    public Button Street_1;
    public Button Street_2;
    public Button newAboutBtn;
    public GameObject LockedImg;
    private void Awake()
    {       
        Time.timeScale = 1f;

        //Santa AudioManager

        AudioManager.instance.StopPlaying("SantaStreet_Music");                
        AudioManager.instance.StopPlaying("Santa_Music");        
        AudioManager.instance.Play("SantaMainMenu_Music");          
         
   
        
                      


        //Normal AudioManager
        AudioManager.instance.StopPlaying("MainMenu_Music");


    }


    void Start()
    {

        LockedStreet1();
        LockedStreet2();
    }


    public void LockedStreet1()
    {
        if (ScoreTextScript.coinAmount <= 0)
        {
            Street_1.interactable = true;
           // print("Welcome! To the game!");
        }

    }

    public void LockedStreet2() 
    {
        if(ScoreTextScript.coinAmount <= 199) 
        {
            LockedImg.SetActive(true);
            Street_2.interactable = false;
  //          print("You can't open this street now!");
        } else

        {
            LockedImg.SetActive(false);
            Street_2.interactable = true;
//            print("Bravo! You unlocked the street!");
        }
    }

    public void LoadStreet1() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaStreet_1");
    }


    public void LoadStreet2()
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaStreet_2");
    }

    public void LoadMainCity() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadNextCity() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaMainMenu_2");
    }

    public void AboutBtn() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("NewAboutScene");
    }




}//Class
