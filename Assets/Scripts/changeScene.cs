using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class changeScene : MonoBehaviour {

    public string scene;

    public void loadScene()
        {
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
}
