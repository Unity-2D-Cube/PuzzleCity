using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Santa_StreetController_3 : MonoBehaviour
{

    public Button SantaLevel_7;
    public Button SantaLevel_8;
    public Button SantaLevel_9;

    public GameObject LockedImg8;
    public GameObject LockedImg9;

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
        LockedLevel_8();
        LockedLevel_9();
    }

    public void LockedLevel_8() 
    {
        if(ScoreTextScript.coinAmount <= 599) 
        {
            Time.timeScale = 1f;
            LockedImg8.SetActive(true);
            SantaLevel_8.interactable = false;
        }else

        {
            Time.timeScale = 1f;
            LockedImg8.SetActive(false);
            SantaLevel_8.interactable = true;
        } 
    }

    public void LockedLevel_9() 
    {
        if(ScoreTextScript.coinAmount <= 799) 
        {
            Time.timeScale = 1f;
            LockedImg9.SetActive(true);
            SantaLevel_9.interactable = false;
        } else 
        {
            Time.timeScale = 1f;
            LockedImg9.SetActive(false);
            SantaLevel_9.interactable = true;
        }
    }

    public void LoadMainMenu() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaMainMenu_2");
    }

    public void LoadSantaLvl_7() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_7");
    }
    public void LoadSantaLvl_8() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_8");
    }
    public void LoadSantaLvl_9() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_9");
    }

}//Class
