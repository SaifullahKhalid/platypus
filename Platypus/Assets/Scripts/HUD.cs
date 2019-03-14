using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    public Sprite[] heartSprites;
    public Image heartUI;
    private Health health;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
    }

    private void Update()
    {
        heartUI.sprite = heartSprites[health.currHealth];
    }
}
