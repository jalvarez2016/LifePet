using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameManagerScript : MonoBehaviour
{
    public Button treat;
    public Button ball;
    public Button toy;
    public float interactions;
    public GameObject ballToy;
    public GameObject treatToy;
    public GameObject catToy;
    // Start is called before the first frame update
    void Start()
    {
        interactions = 0;
    }

    public void Treat(){
        Debug.Log("Hi");
        Instantiate(ballToy, new Vector3(7, 0, 0), Quaternion.identity);
    }

    public void EatTreat(){
        Debug.Log("Hi");
        Instantiate(treatToy, new Vector3(7, 0, 0), Quaternion.identity);
    }

    public void PlayToy(){
        Debug.Log("Hi");
        Instantiate(catToy, new Vector3(Random.Range(-10.0f, 10.0f), 0f,0f), Quaternion.identity);
    }

    public void Interact() {
        interactions++;
        if(interactions >= 4){
            var scene = SceneManager.GetActiveScene();
            Debug.Log("Active Scene is '" + scene.buildIndex + "'.");
            SceneManager.LoadScene(scene.buildIndex + 1);
        }
        Debug.Log("clicked on an interaction button");
    }
	
    // Update is called once per frame
    void Update()
    {
        
    }
}
