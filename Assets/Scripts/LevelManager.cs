using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    protected CameraFadeManager fadeManager;

    private void Start()
    {
        fadeManager = FindObjectOfType<CameraFadeManager>();
        fadeManager.FadeOut();
    }

    public void NextLevel(string nextScene)
    {
        StartCoroutine(NextLevelCR(nextScene));
    }

    protected IEnumerator NextLevelCR(string nextScene)
    {
        fadeManager.FadeIn();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(nextScene);
    }
}
