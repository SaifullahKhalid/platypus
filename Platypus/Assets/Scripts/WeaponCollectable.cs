using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCollectable : MonoBehaviour {
    public int weaponIndex;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
        {
            return;
        }

        if (other.transform.Find("engines_player"))
        {
            other.GetComponent<InputController>().GetWeapon(weaponIndex);
            //PlayerPrefs.SetInt("WeaponType", weaponIndex);

            Debug.Log("Weapon Changed");
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }

        //Destroy(gameObject);
    }
}
