using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowPlayerUI : MonoBehaviour {

    [SerializeField] private ShowModelButton buttonPrefab;

	void Start () {
        var models = FindObjectOfType<PlayerSelectionController>().GetModels();
        for (int i = 0; i < models.Count; i++) {
             CreateButtonForModel(i,models[i]);
        }
        foreach (var model in models) {
           
        }
	}
    private void CreateButtonForModel(int objectToShowIndex, Transform objectToShow) {
        var button = Instantiate(buttonPrefab);
        button.transform.SetParent(transform);
        button.transform.localScale = Vector3.one;
        button.transform.localRotation = Quaternion.identity;
        var controller = FindObjectOfType<PlayerSelectionController>();
        button.Initialize(objectToShowIndex, objectToShow, controller.EnableModel);
        Debug.Log("Set Weapon Now: " + objectToShowIndex);
    }
    
    // Update is called once per frame
    void Update () {
		
	}

    public void PlayBtn() {

        SceneManager.LoadScene("MainGamePlay", LoadSceneMode.Single);
    }
}
