using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    ObjectPooler objectPooler;

    public Toggle starToggle;
    public Toggle heartToggle;
    public Toggle diamondToggle;
    public Toggle rocketToggle;
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
    }
    void FixedUpdate()
    {
        if (starToggle.isOn)
        {
            objectPooler.SpawnFromPool("star", transform.position, Quaternion.identity);
        }
        if (heartToggle.isOn)
        {
            objectPooler.SpawnFromPool("heart", transform.position, Quaternion.identity);
        }
        if (diamondToggle.isOn)
        {
            objectPooler.SpawnFromPool("diamond", transform.position, Quaternion.identity);
        }
        if (rocketToggle.isOn)
        {
            objectPooler.SpawnFromPool("rocket", transform.position, Quaternion.identity);
        }
    }

    
}
