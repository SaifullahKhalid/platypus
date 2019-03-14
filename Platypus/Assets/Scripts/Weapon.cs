using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnDisable()
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void FirePlayerWeapon() {
        GetComponent<Rigidbody>().velocity = transform.right * speed;
    }
   
    void DestroyShip() {
    }

    void DamageAmount(Collider other)
    {
    }
}
