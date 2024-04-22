using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Santa_StreetController_1 : MonoBehaviour
{
    public Button SantaLevel_1;
    public Button SantaLevel_2;
    public Button SantaLevel_3;

    public GameObject LockedImg2;
    public GameObject LockedImg3;

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

        LockedLevel_2();
        LockedLevel_3();
    }

    public void LockedLevel_2() 
    {
        if(ScoreTextScript.coinAmount <= 49) 
        {
            Time.timeScale = 1f;
            LockedImg2.SetActive(true);
            SantaLevel_2.interactable = false;
        }else

        {
            Time.timeScale = 1f;
            LockedImg2.SetActive(false);
            SantaLevel_2.interactable = true;
        } 
    }

    public void LockedLevel_3() 
    {
        if(ScoreTextScript.coinAmount <= 99) 
        {
            Time.timeScale = 1f;
            LockedImg3.SetActive(true);
            SantaLevel_3.interactable = false;
        } else 
        {
            Time.timeScale = 1f;
            LockedImg3.SetActive(false);
            SantaLevel_3.interactable = true;
        }
    }

    public void LoadMainMenu() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaMainMenu_1");
    }

    public void LoadSantaLvl_1() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_1");
    }
    public void LoadSantaLvl_2() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_2");
    }
    public void LoadSantaLvl_3() 
    {
        Time.timeScale = 1f;
        AudioManager.instance.Play("Picked_Correct");
        SceneManager.LoadScene("SantaLevel_3");
    }


}//Class
