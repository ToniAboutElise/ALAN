﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public string name;
    public GameObject[] myText;
    public GameObject[] myAudioSource;
    public AudioSource[] myAudio;
    int sound;
    bool activateDialogue;
    public GameObject deact;

    void Start()
    {
        activateDialogue = true; //this must be false on start
        sound = 0;
    }

    IEnumerator waitSound()
    {
        yield return new WaitForSeconds(3.2f);
        
    }

    void Update () {
        if (activateDialogue)
        {
            myText[sound].SetActive(true);
            myAudioSource[sound].SetActive(true);
        

            if (!myAudio[sound].isPlaying)
            {
                myText[sound].SetActive(false);
                myAudioSource[sound].SetActive(false);
                myAudio[sound].Stop();
                StartCoroutine(waitSound());

                if(sound == myAudio.Length - 1)
                {
                    activateDialogue = false;
                }else
                {
                    sound++;
                }
            }
        }       	
	}
}
