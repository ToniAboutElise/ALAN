using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public int secondsToWait;
    public GameObject[] myText;
    public GameObject[] myAudioSource;
    public AudioSource[] myAudio;
    int sound;
    bool activateDialogue;
    public GameObject deact;
    

    void Start()
    {
        activateDialogue = true;
        sound = 0;
    }

    IEnumerator waitSound()
    {
        yield return new WaitForSeconds(secondsToWait);
        if (activateDialogue)
        {
            myText[sound].SetActive(true);
            myAudioSource[sound].SetActive(true);
            if (!myAudio[sound].isPlaying)
            {
                myText[sound].SetActive(false);
                myAudioSource[sound].SetActive(false);
                myAudio[sound].Stop();

                if (sound == myAudio.Length - 1)
                {
                    activateDialogue = false;
                }
                else
                {
                    sound++;
                }
            }
        }

    }

    void Update () {
        StartCoroutine(waitSound());
	}
}
