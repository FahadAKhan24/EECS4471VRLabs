using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	  //if (Input.GetKeyDown(KeyCode.T))
	 // {
        // TRANSLATION with respect to Y axis
		
		 if (Input.GetKeyDown(KeyCode.W)) // UP
        {
            transform.Translate(0, 3 , 0);  
        }
		else if (Input.GetKeyDown(KeyCode.D)) // RIGHT
		{
			transform.Translate(3, 0 , 0);  
		}
		else if (Input.GetKeyDown(KeyCode.X)) // DOWN
		{
			transform.Translate(0, -3 , 0);  
		}
		else if (Input.GetKeyDown(KeyCode.A)) // LEFT
		{
			transform.Translate(-3, 0 , 0);  
		}
		else
        {
			// do nothing
		}	
      //}
	  
      //else if (Input.GetKeyDown(KeyCode.R)) 
	  //{
         // ROTATION about Z axis
		 
		 if (Input.GetKeyDown(KeyCode.I)) // +90
        {
            transform.Rotate( 0.0f, 0.0f , 90.0f);  
        }
		else if (Input.GetKeyDown(KeyCode.P)) // +180
		{
			transform.Rotate( 0.0f, 0.0f , 180.0f);  
		}
		else if (Input.GetKeyDown(KeyCode.M)) // -90
		{
			transform.Rotate( 0.0f, 0.0f , -90.0f);  
		}
		else if (Input.GetKeyDown(KeyCode.J)) // -180
		{
			transform.Rotate( 0.0f, 0.0f , -180.0f);  
		}
		else
        {
			// do nothing
		}  		  
      //}
      
      //else 
     // {
		  // do nothing
	 // }		  
    }
}


// transform.Translate(0, 0, Time.deltaTime);
// transform.Rotate(90.0f, 0.0f, 0.0f);