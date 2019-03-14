using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ShowModelButton : MonoBehaviour {

    private Transform objectToShow;
    private int objectToShowIndex;
    private Action<Transform,int> clickAction;

    public void Initialize(int objectToShowIndex, Transform objectToShow, Action<Transform,int> clickAction) {
        this.objectToShowIndex = objectToShowIndex;
        this.objectToShow = objectToShow;
        this.clickAction = clickAction;
        GetComponentInChildren<Text>().text = objectToShow.gameObject.name;
        GlobalVariables.weaponIndex = objectToShowIndex;



    }
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(HandleButtonClick);
    }
    private void HandleButtonClick() {
        clickAction(objectToShow,objectToShowIndex);
    }
}
