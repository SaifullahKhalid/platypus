using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedByBoundries : MonoBehaviour {



    private void OnTriggerExit(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
