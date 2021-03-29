using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class CameraFadeManager : MonoBehaviour {

    public Animation fadeAnim;

    public void FadeOut()
    {
        fadeAnim.Play("sphereFadeOut");
    }

    public void FadeIn()
    {
        fadeAnim.Play("sphereFadeIn");
    }
}
