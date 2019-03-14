using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour {

    [SerializeField]
    int damageAmount;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary") || other.CompareTag(gameObject.tag))
        {
            return;
        }

        GameObject explosion = PoolHandler.singleton.explosionPool.GetPooledObject();
        explosion.transform.position = transform.position;
        explosion.SetActive(true);

        Health hlth = other.GetComponent<Health>();
        if (hlth)
        {
            hlth.ChangeHealth(damageAmount); 
        }

        gameObject.SetActive(false);
    }
    
}

