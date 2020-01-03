using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public Button startButton;
    // Use this for initialization 
    void Start () {
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(onClick);
    }

    void onClick() {
        var scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.buildIndex + "'.");
        SceneManager.LoadScene(scene.buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

}
