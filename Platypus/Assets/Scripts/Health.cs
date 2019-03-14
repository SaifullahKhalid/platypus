using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    [SerializeField]
    public int currHealth;
   
    public virtual void ChangeHealth(int changeAmt)
    {
        currHealth -= changeAmt;
        if (currHealth <= 0)
            Die();
    }

    void Die() {
        GameObject explosion = PoolHandler.singleton.explosionPool.GetPooledObject();
        explosion.transform.position = transform.position;
        explosion.SetActive(true);
        gameObject.SetActive(false);
    }

}
