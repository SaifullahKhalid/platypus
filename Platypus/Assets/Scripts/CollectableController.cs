using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour {

    public float frequency = 0.5f;
    float counter = 0.0f;

    public GameObject[] collectableGuns;


    void Start()
    {
        GenerateRandomObj();
    }

    void Update()
    {
        if (counter <= 0.0f)
        {

            GenerateRandomObj();
        }
        else
        {
            counter -= Time.deltaTime * frequency;
            
        }

    }

    void GenerateRandomObj()
    {
        Vector3 spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);
        Instantiate(collectableGuns[Random.Range(0, collectableGuns.Length)], spawnPosition, Quaternion.identity);
        counter = 1.0f;
    }
}
