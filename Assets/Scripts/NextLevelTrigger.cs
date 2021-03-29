using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelTrigger : MonoBehaviour {

    public string nextScene;
    public float delay;

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LoadNextSceneCR());
    }

    public void LoadNextScene()
    {
        StartCoroutine(LoadNextSceneCR());
    }

    protected IEnumerator LoadNextSceneCR()
    {
        yield return new WaitForSeconds(delay);
        FindObjectOfType<LevelManager>().NextLevel(nextScene);
    }
}
