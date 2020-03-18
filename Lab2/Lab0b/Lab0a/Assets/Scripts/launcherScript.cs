using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launcherScript : MonoBehaviour
{
    public GameObject projectile;

    public Camera ProjectileCamera;
    public Camera TargetCamera;
    public Camera MainCamera;

    public float amount = 50f;

    // Start is called before the first frame update
    void Start()
    {
        MainCamera.enabled = true;
        TargetCamera.enabled = false;
        ProjectileCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) // +25
        {
            transform.Rotate(0.0f, 25.0f , 0.0f);
        }
		else if (Input.GetKeyDown(KeyCode.D)) // -25
        {
            transform.Rotate(0.0f, -25.0f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.F)) // -25
        {
            transform.Rotate(-10.0f , 0.0f, 0.0f);
        }
        else if (Input.GetKeyDown(KeyCode.G)) // -25
        {
            transform.Rotate(10.0f , 0.0f, 0.0f);
        }
        else
        {
            // do nothing
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))    // SIMPLE MEDIUM FORCE THROUGH
        {
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            projectile.GetComponent<Rigidbody>().useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))    // SIMPLE SMALL FORCE THROUGH
        {
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 250);
            projectile.GetComponent<Rigidbody>().useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))    // SIMPLE SMALL FORCE THROUGH
        {
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            projectile.GetComponent<Rigidbody>().useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.W))     // LAUNCH WITH TORQUE
        {
            //float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
           // projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
           // projectile.GetComponent<Rigidbody>().AddTorque(transform.up * h);
            //projectile.GetComponent<Rigidbody>().useGravity = true;
        }

        if (Input.GetKeyDown(KeyCode.U) && (ProjectileCamera.enabled == true || TargetCamera.enabled == true))
        {
            ProjectileCamera.enabled = false;
            MainCamera.enabled = true;
            TargetCamera.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.T) && (MainCamera.enabled == true || ProjectileCamera.enabled == true))
        {
            ProjectileCamera.enabled = false;
            MainCamera.enabled = false;
            TargetCamera.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.P) && (MainCamera.enabled == true || TargetCamera.enabled == true))
        {
            ProjectileCamera.enabled = true;
            MainCamera.enabled = false;
            TargetCamera.enabled = false;
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Q))     // LAUNCH WITH TORQUE
        {
            float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
            float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;
            
            projectile.GetComponent<Rigidbody>().AddTorque(transform.up * h);
            projectile.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            projectile.GetComponent<Rigidbody>().AddTorque(transform.up * v);
        }
            
        

        
    }
}
