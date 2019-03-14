using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public AnimationCurve movementCurve;
    public float curveSpeed;
    public float speed;

    float currCrvPos;
    Vector2 prevCrvPos;
    
    void Start () {

    }

    private void FixedUpdate()
    {
        currCrvPos += curveSpeed * Time.fixedDeltaTime;
        Vector2 currCrvVect = new Vector2(currCrvPos, movementCurve.Evaluate(currCrvPos));
        GetComponent<Rigidbody>().velocity = (currCrvVect - prevCrvPos).normalized * speed;
        prevCrvPos = currCrvVect;
//        GetComponent<Rigidbody>().MovePosition(startingPosition + new Vector2(currCrvPos, movementCurve.Evaluate(currCrvPos)));
    }

}
