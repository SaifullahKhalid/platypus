using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public static GameController singleton;

    /// <New Changes>
    private int difLvlCounter = 1;
    private int thresholdLvl = 5;
    private int killedEnmCurrDiff;
    /// public static int killsCount = 0;
    
    
    /// </summary>
    
    public float spawnWait;
    public float startWait;
    public float waveWait;
    private float startingTime;

    public Text scoreText;

    private int score;
    private int[] enemyKilled;

    public Vector3 spawnValues;

    void Start()
    {
        singleton = this;
        score = 0;
        startingTime = Time.time;
        UpdateScore();
        if (killedEnmCurrDiff < thresholdLvl) { 
        StartCoroutine(SpawnWaves());
        }
       

    }

    IEnumerator SpawnWaves()
    {
        

            yield return new WaitForSeconds(startWait);
            while (true)
            {


            Vector3 spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                Quaternion spawnRotation = Quaternion.identity;
                CreateEnemy(PoolHandler.singleton.kamikazeAPool.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateEnemy(PoolHandler.singleton.kamikazeBPool.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateEnemy(PoolHandler.singleton.kamikazeCPool.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateEnemy(PoolHandler.singleton.khudkushBomberA.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateEnemy(PoolHandler.singleton.khudkushBomberB.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateGun(PoolHandler.singleton.collectableGun.GetPooledObject(), spawnPosition, spawnRotation);
                spawnPosition = new Vector3(10f, Random.Range(-3.5f, 5.5f), 0.0f);

                CreateEnemy(PoolHandler.singleton.khudkushBomberC.GetPooledObject(), spawnPosition, spawnRotation);
                yield return new WaitForSeconds(waveWait);
            }

      
    }
   

    void CreateEnemy(GameObject mGameObj,Vector3 spawnPos, Quaternion spawnRot) {
        mGameObj.transform.position = spawnPos;
        mGameObj.transform.rotation = spawnRot;
        mGameObj.SetActive(true);
    }

    void CreateGun(GameObject mGameObj, Vector3 spawnPos, Quaternion spawnRot)
    {
        mGameObj.transform.position = spawnPos;
        mGameObj.transform.rotation = spawnRot;
        mGameObj.SetActive(true);
    }
    public void AddScore(int newScoreValue)
    {
        Debug.Log("Counting");
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
    void GameEnd() {
    }

    public void KillEnemy()
    {
        killedEnmCurrDiff++;
        if(killedEnmCurrDiff > thresholdLvl)
        {
            //reset killed enemies
            killedEnmCurrDiff = 0;
            //increase difficulty

        }
    }

}
