using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    protected CameraFadeManager fadeManager;

    private void Start()
    {
        fadeManager = FindObjectOfType<CameraFadeManager>();
        fadeManager.FadeOut();
    }
}
