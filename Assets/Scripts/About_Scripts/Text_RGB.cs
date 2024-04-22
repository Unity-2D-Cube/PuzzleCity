using UnityEngine;
using UnityEngine.UI;

public class Text_RGB : MonoBehaviour
{

    public Color32 textColor32;    // The color that will be randomly set and
                                   // applied to [textObject].
    public Text textObject;        // The Text object that we want to edit.

    public float timer = 2f;

    void Awake()
    {
        // Initialize [textObject] by getting the
        // Text component of object that this script is attached to.
        textObject = GetComponent<Text>();
        
    }

    void RandomizeTextColor()
    {
        // Randomly set each values of textColor32 by using Random.Range.
        // Call Random.Range and convert the random int value to byte.
        textColor32 = new Color32(
            (byte)Random.Range(0, 255),     // R
            (byte)Random.Range(0, 255),     // G
            (byte)Random.Range(0, 255),     // B
            (byte)Random.Range(0, 255));   // A

        // Set the color of [textObject] to [textColor32]
        textObject.color = textColor32;
    }

    private void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;

        if(timer <=0)
        {
            RandomizeTextColor();
           // Debug.Log(textColor32);
            timer = 1f;
        }
    }


}// class
