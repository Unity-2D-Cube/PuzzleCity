using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SantaMainMenu_2 : MonoBehaviour
{

    public Button MainCity;

    public Button Street_3;
    public Button Street_4;

    public GameObject LockedImg_3;
    public GameObject LockedImg_4;

    private void Awake()
    {
        Time.timeScale = 1f; 

        //Santa AudioManager
        AudioManager.instance.StopPlaying("SantaStreet_Music");                
        AudioManager.instance.StopPlaying("Santa_Music");        
        AudioManager.instance.Play("SantaMainMenu_Music");


    }


    void Start()
    {
        LockedStreet3();
        LockedStreet4();
    }


    public void LockedStreet3()
    {
        if (ScoreTextScript.coinAmount <= 599)
        {
            LockedImg_3.SetActive(true);
            Street_3.interactable = false;
 //           print("You can't open this street now!");
        }else 
        {
            LockedImg_3.SetActive(false);
            Street_3.interactable = true;
    //        print("Bravo! You unlocked the street!");
        }

    }

    public void LockedStreet4() 
    {
        if(ScoreTextScript.coinAmount <= 799) 
        {
            LockedImg_4.SetActive(true);
            Street_4.interactable = false;
    //        print("You can't open this street now!");
        } else

        {
            LockedImg_4.SetActive(false);
            Street_4.interactable = true;
     //       print("Bravo! You unlocked the street!");
        }
    }

    public void LoadStreet3() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaStreet_3");
    }


    public void LoadStreet4()
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaStreet_4");
    }

    public void LoadMainCity() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaMainMenu_1");
    }



}//Class
