using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTextTrigger : MonoBehaviour {

    public StoryText storyText;
    protected bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if(played == false)
        {
            played = true;
            storyText.PlayTextSquence();
        }
    }
}
