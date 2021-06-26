using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AngelSpawn : MonoBehaviour
{
    private float[] array;
    public GameObject angel;
    
    // Start is called before the first frame update
    void Start()
    {
        array = new float[3];
        array[0] = -3.3f;
        array[1] = 0f;
        array[2] = 3.3f;
        StartCoroutine("Spawn");

    }

    private void Update()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(angel, new Vector3(array[Random.Range(0, 3)], 13 , 0), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
    
}
