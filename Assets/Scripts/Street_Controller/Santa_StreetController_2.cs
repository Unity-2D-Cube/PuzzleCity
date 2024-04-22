using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Santa_StreetController_2 : MonoBehaviour
{

    public Button SantaLevel_4;
    public Button SantaLevel_5;
    public Button SantaLevel_6;

    public GameObject LockedImg5;
    public GameObject LockedImg6;

    private void Awake()
    {
        Time.timeScale = 1f;
        
        //Santa AudioManager
        AudioManager.instance.Play("SantaStreet_Music");        
        AudioManager.instance.StopPlaying("SantaMainMenu_Music");  
        AudioManager.instance.StopPlaying("Santa_Music");     
    }
         
     
    // Start is called before the first frame update
    void Start()
    {
        LockedLevel_5();
        LockedLevel_6();
    }

    public void LockedLevel_5() 
    {
        if(ScoreTextScript.coinAmount <= 299) 
        {
            Time.timeScale = 1f;
            LockedImg5.SetActive(true);
            SantaLevel_5.interactable = false;
        }else

        {
            Time.timeScale = 1f;
            LockedImg5.SetActive(false);
            SantaLevel_5.interactable = true;
        } 
    }

    public void LockedLevel_6() 
    {
        if(ScoreTextScript.coinAmount <= 399) 
        {
            Time.timeScale = 1f;
            LockedImg6.SetActive(true);
            SantaLevel_6.interactable = false;
        } else 
        {
            Time.timeScale = 1f;
            LockedImg6.SetActive(false);
            SantaLevel_6.interactable = true;
        }
    }


    public void LoadMainMenu() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaMainMenu_1");
    }

    public void LoadStreet2() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaStreet_2");
    }

    public void LoadSantaLvl_4() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_4");
    }
    public void LoadSantaLvl_5() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_5");
    }
    public void LoadSantaLvl_6() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_6");
    }


    

}//Class
