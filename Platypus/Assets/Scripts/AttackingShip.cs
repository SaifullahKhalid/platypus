using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingShip : BaseShip {
    public float tumble;
    public float speed;
    public GameObject explosion;
    public GameObject playerExplosion;


    void Start () { }
	void Update () { }

    void Fire() { }
    void Weapon() { }


    public void Movement() {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        GetComponent<Rigidbody>().velocity = -transform.right * speed;

    }


}
