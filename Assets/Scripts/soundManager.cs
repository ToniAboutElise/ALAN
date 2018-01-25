using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public string name;
    public GameObject[] myText;
    public GameObject[] myAudioSource;
    public AudioSource[] myAudio;
    int sound;
    bool activateDialogue;
    bool loop;
    bool loopFor;

    void Start()
    {
        activateDialogue = true; //this must be false on start
        loop = true;
        loopFor = true;
        sound = 0;
    }

    IEnumerator waitSound()
    {
        sound++;
        yield return new WaitForSeconds(3.2f);
        
    }

    void Update () {

        if (activateDialogue)
        {
            myText[sound].SetActive(true);
            myAudioSource[sound].SetActive(true);
        }

        if (!myAudio[sound].isPlaying)
        {
            myText[sound].SetActive(false);
            myAudioSource[sound].SetActive(false);
            myAudio[sound].Stop();
            StartCoroutine(waitSound());
        }

	    /*
        for(int i = 0; i <= myText.Length; i++)
        {
            while(loopFor)
            myText[i].SetActive(true);
            myAudioSource[i].Play();
            while (loop)
            {
                if (!myAudioSource[i].isPlaying)
                {
                    loop = true;
                }else
                {
                    StartCoroutine(waitSound());
                    loop = false;
                }  
            }
            loopFor = false;
            loop = true;
        }
        */
        	
	}
}
