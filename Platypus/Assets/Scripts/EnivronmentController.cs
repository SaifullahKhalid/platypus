
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnivronmentController : MonoBehaviour {
    //public float scrollSpeed = 5.0f;
    //public float frequency = 0.5f;
    //float counter = 0.0f;

    //public GameObject[] randomObjects;
    //public GameObject[] treeObjects;

    //public Transform randomSpawnPoint;
    //public Transform treeSpawnPoint;

    public float spawnWait;
    public float startWait;
    public float waveWait;
    public GameObject[] hazards;
    public int hazardCount;


    void Start () {
        //GenerateRandomObj();
        StartCoroutine(SpawnWaves());
    }
	
	// Update is called once per frame
	void Update () {
        //if (counter <= 0.0f)
        //{

        //    GenerateRandomObj();
        //}
        //else {
        //    counter -= Time.deltaTime * frequency;
        //}
        //counter -= Time.deltaTime * frequency;
        //GenerateRandomTrees();

        //GameObject currentChild;
        //for (int i = 0; i < transform.childCount; i++) {
        //    currentChild = transform.GetChild(i).gameObject;
        //    //ScrollObject(currentChild);
        //}
    }

    //private void ScrollObject(GameObject currentObject)
    //{
    //    currentObject.transform.position -=  Vector3.right * (scrollSpeed * Time.deltaTime);
    //    Debug.Log("scroll object postiotion: "+currentObject.transform.position);
        
    //}
    //void GenerateRandomObj() {
        
    //    Instantiate(randomObjects[Random.Range(0,randomObjects.Length)],randomSpawnPoint.position,Quaternion.identity);

    //    counter = 1.0f;
    //}
    //void GenerateRandomTrees()
    //{

    //    Instantiate(treeObjects[Random.Range(0, treeObjects.Length)], treeSpawnPoint.position, Quaternion.identity);

    //    counter = 1.0f;
    //}

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
            GameObject hazard = hazards[Random.Range(0, hazards.Length)];
            Vector3 spawnPosition = new Vector3(10f, 0.0f, Random.Range(1.5f, 5.5f));
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(hazard, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
                //for (int i = 0; i < hazardCount; i++)
                //{
                //    // Don't need of Hazads array anymore
                //    //GameObject hazard = hazards[Random.Range(0, hazards.Length)];


                //Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                //    Vector3 spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

            }

        yield return new WaitForSeconds(waveWait);
        }
    }
    void CreateEnemy(GameObject mGameObj, Vector3 spawnPos, Quaternion spawnRot)
    {
        mGameObj.transform.position = spawnPos;
        mGameObj.transform.rotation = spawnRot;
        mGameObj.SetActive(true);
    }

}
