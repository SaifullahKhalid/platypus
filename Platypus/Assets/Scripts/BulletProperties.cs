using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Bullet", menuName = "Inventory/Bullet", order = 1)]
public class BulletProperties : ScriptableObject {

    public Sprite bulletTexture;
    public Vector3 bulletSize;
    public float bulletSpeed;
    public int bulletDamage;

}
