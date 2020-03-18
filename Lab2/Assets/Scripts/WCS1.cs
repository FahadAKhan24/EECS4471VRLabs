using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCS1 : MonoBehaviour
{
    public GameObject sphere_for_modify;
    public GameObject cube_for_modify;
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // gravity toggle/slider fucntions
    public void Scaling_Slider(float newValue)
    {
        sphere_for_modify.transform.localScale = new Vector3(newValue, newValue, newValue);
        
    }

    public void Color_Toggled(bool newValue)
    {
        sphere_for_modify.GetComponent<Renderer>().material.SetColor("_Color", Color.red);

    }

    public void Rotation_Slider(float newValue)
    {
        
        cube_for_modify.transform.rotation = Quaternion.Euler(0, newValue, newValue);

    }

    public void Position_Toggled(bool newValue)
    {
        cube_for_modify.transform.position = new Vector3(4, 2, 3);

    }
}
