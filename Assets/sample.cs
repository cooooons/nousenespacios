using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{

    public GameObject objectToSpawn;

    public Vector3 objectPosition = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objectToSpawn, objectPosition, Quaternion.identity);
        }
    }

  
}
