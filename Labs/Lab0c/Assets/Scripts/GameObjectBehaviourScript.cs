using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectBehaviourScript : MonoBehaviour  // this is to be attached to CUBE
{

    // public GameObject Cube;
	// public GameObject Plane;
   // public GameObject PhotoPlane;
   // HOW DO I REFER TO GAMEOBJECT CUBE ITSELF? 
   // SHOULD THERE BE TWO DIFFERENT SCRIPTS FOR CUBE AND SPHERE INORDER TO SWITCH BETWEEN THEM
   
    public GameObject Sphere;
	// You can now drag an object from the scene
    // or Hierarchy panel onto this variable to assign it in inspector window
	
   
    
    // Start is called before the first frame update
    void Start()
    {
       // Cube = GameObject.Find("Cube");
        Sphere = GameObject.Find("Sphere");
        Sphere.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (gameObject.activeSelf == true)             // cube is active so switch to Sphere
            {
                //gameObject.SetActive(false);
				//gameObject.SetActive(false);
                Sphere.SetActive(true);
                Sphere.transform.position = new Vector3(2, 4, 0);
                

               
            }

            else if (Sphere.activeSelf == true)    // sphere is active so switch to Cube
            {
               // Sphere.SetActive(false);
                gameObject.SetActive(true);
                //gameObject.SetActive(true);
                gameObject.transform.position = new Vector3(0, 4, 0);
				//gameObject.transform.position = new Vector3(0, 3.5, 0);
            }

            else {
                  // do nothing
            }

        }

        if (Input.GetKeyDown(KeyCode.K))
        {

            Destroy(Sphere);  // currently selected game object

        }

        if (Input.GetKeyDown(KeyCode.N))
        {

            Instantiate(Sphere, new Vector3(3, 1, 0), Quaternion.identity);  // currently selected game object

        }
        
    }
}
