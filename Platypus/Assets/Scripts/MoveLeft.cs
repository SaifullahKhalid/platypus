﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    public float speed = 1;
    // Use this for initialization
    void Start () {
      //  transform.position -= Vector3.left * (Time.deltaTime * speed);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position -= Vector3.right * (Time.deltaTime * speed);

    }
}
