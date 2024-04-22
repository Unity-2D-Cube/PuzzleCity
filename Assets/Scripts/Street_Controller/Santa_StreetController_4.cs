using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Santa_StreetController_4 : MonoBehaviour
{

public Button SantaButton_10;
public Button SantaButton_11;
public Button SantaButton_12;

public GameObject LockedImg_11;
public GameObject LockedImg_12;


private void Awake()
{
    Time.timeScale = 1f;

    //Santa AudioManager
    AudioManager.instance.Play("SantaStreet_Music");        
    AudioManager.instance.StopPlaying("SantaMainMenu_Music");  
    AudioManager.instance.StopPlaying("Santa_Music");     
}
private void Start()
{
    LockedStreet_11();
    LockedStreet_12();
}

public void LockedStreet_11() 
{
    if(ScoreTextScript.coinAmount <= 1199) 
    {
        LockedImg_11.SetActive(true);
        SantaButton_11.interactable = false;
   //     print("0");
    } else 
    {
        LockedImg_11.SetActive(false);
        SantaButton_11.interactable = true;
    //    print("1");
    }
}

public void LockedStreet_12() 
{
    if(ScoreTextScript.coinAmount <= 1999) 
    {
        LockedImg_12.SetActive(true);
        SantaButton_12.interactable = false;
   //     print("00");
    } else 
    {
        LockedImg_12.SetActive(false);
        SantaButton_12.interactable = true;
     //   print("11");
    }
}

public void LoadMainMenu() 
{
    Time.timeScale = 1f;
    AudioManager.instance.Play("Picked_Correct");
    SceneManager.LoadScene("SantaMainMenu_2");
}

public void LoadStreet_4() 
{
    Time.timeScale = 1f;
    AudioManager.instance.Play("Picked_Correct");
    SceneManager.LoadScene("SantaStreet_4");
}

public void LoadLevel_10() 
{
    Time.timeScale = 1f;
    AudioManager.instance.Play("Picked_Correct");
    SceneManager.LoadScene("SantaLevel_10");
}

public void LoadLevel_11() 
{
    Time.timeScale = 1f;
    AudioManager.instance.Play("Picked_Correct");
    SceneManager.LoadScene("SantaLevel_11");
}

public void LoadLevel_12() 
{
    Time.timeScale = 1f;
    AudioManager.instance.Play("Picked_Correct");
    SceneManager.LoadScene("SantaLevel_12");
}

}//Class
