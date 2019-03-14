using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[System.Serializable]
public class Boundary {

    public float xMin, xMax, yMin, yMax;
}

public class InputController : MonoBehaviour {
    public static int weaponComboInd;


    public float speed;
    public float tilt;
   // public float a, b, c;
    public Boundary boundary;

    public GameObject shot;
    public Transform[] shotSpawns;

    public float fireRate;
    private float nextFire;

    private BulletSelector.BulletLayout currBltLyt;

    public void GetWeapon(int weaponIndex)
    {
        currBltLyt = PoolHandler.singleton.PlayerWeaponChange(weaponComboInd, weaponIndex);
    }

    private void Start()
    {
        weaponComboInd = GlobalVariables.weaponIndex;
        Debug.Log("Global Variable: " + weaponComboInd);
        GetWeapon(0);
    }

    private void Update()
    {
        if (CrossPlatformInputManager.GetButton("Fire1") && Time.time > nextFire) {
            nextFire = Time.time + fireRate;

            //GameObject obj = ObjectPooler.current.GetPooledObject();
            //if (obj == null) return;
            //obj.transform.position = transform.position;
            //obj.transform.rotation = transform.rotation;
            //obj.SetActive(true);

         

            foreach (int shotSpawnInd in currBltLyt.bltSpnPntInds)
            {
                GameObject obj = PoolHandler.singleton.pbltPool.GetPooledObject();
                if (obj == null) return;
                obj.transform.position = shotSpawns[shotSpawnInd].position;;
                obj.transform.rotation = shotSpawns[shotSpawnInd].rotation;
                obj.SetActive(true);
            }

            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    private void FixedUpdate()
    {
        float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * speed;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x,-7,7),
            Mathf.Clamp(GetComponent<Rigidbody>().position.y, -3, 5),
            0.0f
            
        );
      //  GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 90f, GetComponent<Rigidbody>().velocity.y*tilt);


    }

}
