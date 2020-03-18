using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour
{
    public Slider slider_gravity;
    public Text gravity_value;
    public Slider slider_light;
    public Light spotlight;
    public Button button_add_object;
    public GameObject cube_primitive;
    public Button button_fall__under_gravity;
    public Button button_force;
    public GameObject sphere_for_gravity;
    public GameObject launcher_for_gravity;
    public Canvas screen_overlay;  // Canvas screen overlay



    // Start is called before the first frame update
    void Start()
    {
        //slider.GameObject.Find("Slider").GetComponent<Slider>();
        gravity_value.text = "Gravity is: -" + slider_gravity.value.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M)) // enabling/disabling  Canvas
        {
            screen_overlay.enabled = !screen_overlay.enabled;
        }
    }

    // gravity toggle/slider fucntions
    public void Gravity_Slider(float newValue)
    {
        Physics.gravity = new Vector3(0f, -newValue, 0f);
        gravity_value.text = "Gravity is: -" + newValue.ToString();
    }

    public void Gravity_Toggled(bool newValue)
    {
        gravity_value.enabled = newValue;
        slider_gravity.interactable = newValue;

    }

    // light toggle/slider fucntions
    public void Light_Slider(float newValue)
    {
        spotlight.intensity = newValue;
    }

    public void Light_Toggled(bool newValue)
    {
        slider_light.interactable = newValue;

    }
    // add button fucntions
    public void Button_add_On_Click()
    {
        Instantiate(cube_primitive, new Vector3(4.0F, 0, 0), Quaternion.identity);
    }

    public void Button_fall_On_Click()
    {   // add touch controller part here
        sphere_for_gravity.AddComponent<Rigidbody>();
        sphere_for_gravity.GetComponent<Rigidbody>().useGravity = true;
        sphere_for_gravity.GetComponent<Rigidbody>().isKinematic = false;

        launcher_for_gravity.AddComponent<Rigidbody>();
        launcher_for_gravity.GetComponent<Rigidbody>().useGravity = true;
        launcher_for_gravity.GetComponent<Rigidbody>().isKinematic = false;
    }

    public void Button_force_On_Click()
    {    // add touch controller part here

        sphere_for_gravity.AddComponent<Rigidbody>();
        sphere_for_gravity.GetComponent<Rigidbody>().mass = 2;
        sphere_for_gravity.GetComponent<Rigidbody>().AddForce(transform.right * 500);

        launcher_for_gravity.AddComponent<Rigidbody>();
        launcher_for_gravity.GetComponent<Rigidbody>().mass = 4;
        launcher_for_gravity.GetComponent<Rigidbody>().AddForce(transform.right * 500);

        cube_primitive.GetComponent<Rigidbody>().mass = 0.5f;
        cube_primitive.GetComponent<Rigidbody>().AddForce(transform.right * 500);
    }




}
