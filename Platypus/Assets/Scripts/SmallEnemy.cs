using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : AttackingShip {
    public int scoreValue;
    private GameController gameController;
    public static int killedEnemies = 0;


    // Use this for initialization
    void Start () {

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }
        if(explosion != null) { 
        Instantiate(explosion, transform.position, transform.rotation);
        }
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //Debug.Log("Killed Enemies" + GlobalVariables.killedEnemies);
        }
        gameController.AddScore(scoreValue);
       
        //Destroy(gameObject);
        gameObject.SetActive(false);
    }



}
