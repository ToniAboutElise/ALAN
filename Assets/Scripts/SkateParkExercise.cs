using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateParkExercise : MonoBehaviour {

    public SkateParkExperienceController controller;
    public StoryText storyText;
    protected int currentBallAmount = 0;
    public int targetBallAmount;

    public void AddNextBall()
    {
        currentBallAmount++;
        if(currentBallAmount == targetBallAmount)
        {
            storyText.PlayTextSquence();
            controller.CheckCompletedExercises();
        }
    }
}
