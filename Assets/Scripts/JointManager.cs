using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointManager : MonoBehaviour
{

    public GameObject objectToActivate;
    public string anim1;
    public string anim2;
    public Animation anim;
    bool isOpen;
    bool isClosed;
    bool isPlaying;

    void Start()
    {
        objectToActivate.GetComponent<BoxCollider>().enabled = false;
        isOpen = false;
        isClosed = true;
        isPlaying = false;
    }

    IEnumerator activate()
    {
        if (anim.IsPlaying(anim1))
        {
        Debug.Log("Starting coroutine");
        yield return new WaitForSeconds(1);
        objectToActivate.GetComponent<BoxCollider>().enabled = true;
        Debug.Log("objectToActivate box collider enabled");
        }
    }

    void OnTriggerStay(Collider other)
    {


        if (other.gameObject.tag == "interact" && isClosed)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Enters closed");
                anim = GetComponent<Animation>();
                anim.Play(anim1);
                if (anim.IsPlaying(anim1))
                {
                    gameObject.GetComponent<BoxCollider>().enabled = false;
                    isPlaying = true;
                    StartCoroutine(activate());
                }
                else
                if (!anim.IsPlaying(anim1) && isPlaying)
                {
                    gameObject.GetComponent<BoxCollider>().enabled = true;
                    isClosed = false;
                    isOpen = true;
                    isPlaying = false;
                }
            }
        }
  
    }
}

