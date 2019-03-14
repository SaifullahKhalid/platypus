using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectionController : MonoBehaviour {
    private List<Transform> models;

    private void Awake()
    {
        models = new List<Transform>();
        for (int i = 0; i < transform.childCount; i++) {
            var model = transform.GetChild(i);
            models.Add(model);
            model.gameObject.SetActive(i == 0);
        }
    }

    public void EnableModel(Transform modelTransform, int gunIndex)
    {
        GlobalVariables.weaponIndex = gunIndex;
        for (int i = 0; i < transform.childCount; i++) {
            var trasformToToggle = transform.GetChild(i);
            bool shouldBeActive = trasformToToggle == modelTransform;
            trasformToToggle.gameObject.SetActive(shouldBeActive);
        }

    }

    public List<Transform> GetModels() {
        return new List<Transform>(models);
    }
}
