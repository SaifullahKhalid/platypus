using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerController : MonoBehaviour {

    private int difLvlCounter = 1;
    private int thresholdLvl = 200;
    private int killedEnemies = 0;

    private int ESWave = 1;

    private void Update()
    {
        if (killedEnemies > thresholdLvl) {
            // Spawn Enemeis

        }
    }


}
