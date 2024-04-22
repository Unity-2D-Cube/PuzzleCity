using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    


    //public float degreesPerSec = 360f;

    void FixedUpdate()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
          //  Rotate();
        }
    }

    private void Rotate()
    {
        
        transform.Rotate(Vector3.up * 180);

        //transform.Rotate(Vector3.up * Random.Range(-0, 180));
    }


    /*  private void FixedUpdate()
      {
          if(Input.GetMouseButtonDown(0))
          {
              RotateLeft();
          }else
          {
              //RotateRight();
          }
      }

      private void RotateLeft()
      {
          transform.Rotate(new Vector3(0f, 180f, 0f * Time.fixedDeltaTime +1f));

         // transform.eulerAngles = new Vector3(0, 0, -90 * Time.timeScale *1f);
      }

      private void RotateRight()
      {
          transform.eulerAngles = new Vector3(0, 180, 0 * Time.timeScale * 1f);
      }
      */
} // class
