using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSideMover : MonoBehaviour {

    public float speed;
    
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Rigidbody>().MovePosition(transform.position + transform.right * speed * Time.fixedDeltaTime);
	}
}
