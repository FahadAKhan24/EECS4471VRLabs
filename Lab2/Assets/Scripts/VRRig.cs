using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRig : MonoBehaviour
{
    //public Transform touchL;
    //public Transform touchR;
    //public Vector2 rightStick;
    public GameObject sphere_for_gravity;
    public GameObject launcher_for_gravity;
    public GameObject cube_primitive;

    public Transform touchL;
    public Transform touchR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // pressing B on controller , objects fall under gravity
         
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            sphere_for_gravity.AddComponent<Rigidbody>();
            sphere_for_gravity.GetComponent<Rigidbody>().useGravity = true;
            sphere_for_gravity.GetComponent<Rigidbody>().isKinematic = false;

            launcher_for_gravity.AddComponent<Rigidbody>();
            launcher_for_gravity.GetComponent<Rigidbody>().useGravity = true;
            launcher_for_gravity.GetComponent<Rigidbody>().isKinematic = false;
        }
        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            sphere_for_gravity.AddComponent<Rigidbody>();
            sphere_for_gravity.GetComponent<Rigidbody>().mass = 2;
            sphere_for_gravity.GetComponent<Rigidbody>().AddForce(transform.right * 500);

            launcher_for_gravity.AddComponent<Rigidbody>();
            launcher_for_gravity.GetComponent<Rigidbody>().mass = 4;
            launcher_for_gravity.GetComponent<Rigidbody>().AddForce(transform.right * 500);

            cube_primitive.GetComponent<Rigidbody>().mass = 0.5f;
            cube_primitive.GetComponent<Rigidbody>().AddForce(transform.right * 500);
        }
        // set position for each controller (explicitly)
        touchL.localPosition= OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
        touchR.localPosition= OVRInput.GetLocalControllerPosition(OVRInput.Controller.RTouch);
        // set rotation for each controller (explicitly)
        touchL.localRotation= OVRInput.GetLocalControllerRotation(OVRInput.Controller.LTouch);
        touchR.localRotation= OVRInput.GetLocalControllerRotation(OVRInput.Controller.RTouch);

        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            sphere_for_gravity.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            sphere_for_gravity.transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            cube_primitive.transform.position = new Vector3(4, 2, 3);
            cube_primitive.transform.rotation = Quaternion.Euler(0, 45.0f, 45.0f);
        }
    }
}
