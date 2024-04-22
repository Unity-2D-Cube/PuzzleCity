using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{

    public static Text text;

    public static int coinAmount;



    // Start is called before the first frame update
    void Awake()
    {

        text = GetComponent<Text>();

        coinAmount = PlayerPrefs.GetInt("Text_Coins", coinAmount);

        text.text = coinAmount.ToString();

    }

    // Update is called once per frame
    void LateUpdate()
    {
        text.text = coinAmount.ToString();
                 
        text.text = "" + coinAmount;

        PlayerPrefs.SetInt("Text_Coins", coinAmount);
        
    }

    public void RestartScore()
    {
        coinAmount = 0;
    }

    public void ExtraScore()
    {
        coinAmount = 100000;
    }


}// class
