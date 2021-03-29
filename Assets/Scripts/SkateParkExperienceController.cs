using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkateParkExperienceController : MonoBehaviour {

    public List<SkateParkExercise> exerciseList;

    public void CheckCompletedExercises()
    {
        FindObjectOfType<LevelManager>().NextLevel("");
    }
}
