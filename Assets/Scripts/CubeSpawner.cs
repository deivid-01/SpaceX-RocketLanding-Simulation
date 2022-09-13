using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public  GameObject cube; //Cubo Prefab
    public GameObject cubeSpawned; // Cubo n-esimo generado

    public bool next; //Saltar al siguiente cubo;

    #region Singlenton
    public static CubeSpawner Instance;
    private void Awake()
    {
        Instance = this;
    }
    #endregion

    void Start()
    {
        next = true;
        cubeSpawned = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (next == true)
        {
            SpawnCube();

        }
        if (cubeSpawned != null)
        {
            Debug.Log("Speed " + cubeSpawned.GetComponent<Rigidbody>().velocity.magnitude);

        }
    }   

    void SpawnCube()
    {
        cubeSpawned = Instantiate(cube, transform.position, Quaternion.identity);
        next = false;
    }
}
