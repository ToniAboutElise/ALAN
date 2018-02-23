using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballActivatesBall : MonoBehaviour {

    public GameObject ballToDeact;
    public GameObject[] ballToAct;
    public GameObject myBallManager;

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "ball")
        {
            Debug.Log("enters");
            for (int i = 0; i < ballToAct.Length; i++)
            {
                ballToAct[i].SetActive(true);
            }
            myBallManager.GetComponent<ballManager>().totalCount += 1;
            myBallManager.GetComponent<ballManager>().dialogue += 1;
            ballToDeact.SetActive(false);
        }
    }

}
