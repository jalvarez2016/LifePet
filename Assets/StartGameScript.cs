using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetActiveSceneExample : MonoBehaviour
{
    void StartGame()
    {
        var scene = SceneManager.GetActiveScene();
        Debug.Log("Active Scene is '" + scene.name + "'.");
    }
}
