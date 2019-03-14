using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    public float delay;
    public AudioClip[] clips;

    private AudioSource audioSource;

    void OnEnable ()
    {
        audioSource = GetComponent<AudioSource> ();
        InvokeRepeating ("Fire", delay, fireRate);
    }
    private void OnDisable()
    {
        CancelInvoke("Fire");
    }

    void Fire ()
    {
        GameObject enemyBullet = PoolHandler.singleton.enemyBulletsPool.GetPooledObject();

        enemyBullet.transform.position = shotSpawn.position;
        enemyBullet.transform.rotation = shotSpawn.rotation;
        enemyBullet.SetActive(true);
        //Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        AudioClip clip = clips[Random.Range(0, clips.Length)];
        audioSource.clip = clip;
        audioSource.Play ();
    }
    
}
