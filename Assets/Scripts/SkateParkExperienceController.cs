using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateParkExperienceController : MonoBehaviour {

    private int exercisesCompleted = 0;
    public List<SkateParkExercise> exerciseList;

    public void CheckCompletedExercises()
    {
        exercisesCompleted++;
        if (exercisesCompleted == exerciseList.Count)
        FindObjectOfType<LevelManager>().NextLevel("");
    }
}
