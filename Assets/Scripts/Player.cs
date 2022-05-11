using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed=7;
    void Start()
    {
        
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputZ = Input.GetAxisRaw("Vertical");
        
        Vector3 velocity = new Vector3(inputX,0, inputZ) * speed;

        transform.Translate(velocity * Time.deltaTime);
    }
}
