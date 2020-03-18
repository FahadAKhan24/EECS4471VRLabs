using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public Camera MainCamera;
    public Camera ProjectileCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 500);
        GetComponent<Rigidbody>().useGravity = true;
    }

    void OnCollisionEnter (Collision collision)
    {
        Debug.Log("Enter called");
        
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("stay called");
        //ProjectileCamera.enabled = false;
    }

    void OnCollisionExit(Collision collision)
    {
        Debug.Log("exit called");
        //yield return new WaitForSeconds(5f);
        //Invoke(ProjectileCamera.enabled = false && MainCamera.enabled = true, 5.0f);
        // ProjectileCamera.enabled = false;
        // MainCamera.enabled = true;
    }

}
