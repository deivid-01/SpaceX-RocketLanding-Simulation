using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingDetection : MonoBehaviour
{
    public Transform objtransform; 
    public Rigidbody rb;
    public GameObject particle;

    bool landingOn;

    private void Start()
    {
        landingOn = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        landingOn = true;
        Debug.Log("Landing On");
      
    }

    private void FixedUpdate()
    {
        if (landingOn)
        {
            Landing();
        }
        Debug.Log("Speed: "+rb.velocity.magnitude+"| Hight: "+objtransform.position.y);
    }
    void Landing()
    {
        particle.SetActive(true);
        if (rb.velocity.magnitude > 5)
        {
            //rb.AddForce(0, 1200 * Time.deltaTime, 0);
            rb.AddForceAtPosition(Vector3.up* 1800 * Time.deltaTime, objtransform.position + Vector3.down*4);
        }
    }
}
