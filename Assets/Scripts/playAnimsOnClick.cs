using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimsOnClick : MonoBehaviour {

    public GameObject[] objToAnim;
    

    bool notAnim;



    void Awake()
    {
        notAnim = false;
    }
	
	void OnTriggerStay(Collider other)
    {
        if(other.tag == "interactArea" && Input.GetMouseButton(0) && !notAnim){
            for(int i = 0; i <= objToAnim.Length; i++) { 
            objToAnim[i].GetComponent<Animation>().Play();
            notAnim = true;
            Debug.Log("Playing");
            }
        }
    }
}
