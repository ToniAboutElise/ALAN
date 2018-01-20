using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimsOnClick : MonoBehaviour {

    public GameObject[] objToAnim;
    public GameObject objToAct;
    public GameObject objToDeact;

    public bool openDoor;
    bool notAnim;

    void Awake()
    {
        notAnim = false;
    }
	
	void OnTriggerStay(Collider other)
    {
        if(other.tag == "interactArea" && Input.GetMouseButton(0) && !notAnim){
            if (openDoor)
            {
                objToAct.SetActive(true);
                objToDeact.SetActive(false);
            }
            for (int i = 0; i <= objToAnim.Length; i++) {
                
                objToAnim[i].GetComponent<Animation>().Play();
            notAnim = true;
            Debug.Log("Playing");
            }
        }
    }
}
