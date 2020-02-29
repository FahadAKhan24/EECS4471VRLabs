using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {

            // light.intensity = 4.0;  // currently selected game object
            GetComponent<Light>().intensity = 4.0f;
        } 
    }
}
