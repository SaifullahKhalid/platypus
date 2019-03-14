using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponLayouts", menuName = "Inventory/Weapon Layouts", order = 1)]
public class BulletSelector : ScriptableObject {
   [System.Serializable]
   public struct BulletLayout
    {
        public int[] bltSpnPntInds;
        public GameObject bullet;
    }
    [System.Serializable]
    public struct BulletLayoutCombo
    {
        public BulletLayout[] layouts;
    }

    public BulletLayoutCombo[] LayoutCombo;
}
