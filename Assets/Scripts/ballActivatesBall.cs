using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballActivatesBall : MonoBehaviour {

    public GameObject ballToDeact;
    public GameObject[] ballToAct;
    public GameObject myBallManager;
    public SkateParkExercise exercise;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "ball")
        {
            Debug.Log("enters");
            for (int i = 0; i < ballToAct.Length; i++)
            {
                ballToAct[i].SetActive(true);
            }
            ballToDeact.SetActive(false);
            exercise.AddNextBall();
        }
    }

}
