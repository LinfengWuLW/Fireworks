using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour, IPooledObject
{
    public float upForce = 5;
    public float sideForce = 5;
    public void OnObjectSpawn()
    {
        float xForce = Random.Range(sideForce/2f, sideForce);
        float yForce = Random.Range(-upForce/2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);
        GetComponent<Rigidbody>().velocity = force;
    }

    
}
