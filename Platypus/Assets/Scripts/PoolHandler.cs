using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolHandler : MonoBehaviour {

    public static PoolHandler singleton;

    public ObjectPooler template;
    public BulletSelector bulletSOB;
    [HideInInspector]
    public ObjectPooler pbltPool;
    public ObjectPooler kamikazeAPool, kamikazeBPool, kamikazeCPool, khudkushBomberA, khudkushBomberB, khudkushBomberC, explosionPool,enemyBulletsPool,collectableGun;
        
    private void Awake()
    {
        singleton = this;
    }
    
    public BulletSelector.BulletLayout PlayerWeaponChange(int wepLayoutInd, int wepInd)
    {
        pbltPool = Instantiate(template, transform);
        pbltPool.pooledObject = bulletSOB.LayoutCombo[wepLayoutInd].layouts[wepInd].bullet;
        return bulletSOB.LayoutCombo[wepLayoutInd].layouts[wepInd];
    }

}
