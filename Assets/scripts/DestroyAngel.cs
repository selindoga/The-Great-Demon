using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAngel : MonoBehaviour
{
    // I don't use this script now.
    // maybe in future changes I can use it, maybe...
    
    public float timeToKill;
    void Start()
    {
        timeToKill = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        timeToKill -= Time.deltaTime;

        if (timeToKill <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
