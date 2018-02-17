using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateBallPhysics : MonoBehaviour {
    public GameObject ball;
    public GameObject refPos;

    public Animation anim;
    public GameObject UI;
    Vector3 initPos;

    bool ballIsOn;

    void Start()
    {
        initPos = refPos.transform.position;
        ball.SetActive(false);
    }

    void Update()
    {
        ballIsOn = ball.GetComponent<ballState>().isOn = true;
    }

    void OnTriggerStay(Collider other)
    {

        if (other.tag == "interactArea")
        {
            UI.SetActive(true);
        }

        if (other.tag == "interactArea" && Input.GetMouseButton(0) && ballIsOn)
        {
            anim.Play();
            ball.SetActive(true);
            ball.GetComponent<MeshRenderer>().enabled = true;
            ball.GetComponent<ballState>().isOn = true;
            ball.transform.position = initPos;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(false);
        }
    }

}
