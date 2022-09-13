using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    public Rigidbody rb;
    CubeSpawner cubespawner;
    bool boom = false; //He's already collided;

    private void Start()
    {
        cubespawner = CubeSpawner.Instance;
    }

    private void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!boom)
        { cubespawner.next = true;
          boom = true;
        }
    }
}
