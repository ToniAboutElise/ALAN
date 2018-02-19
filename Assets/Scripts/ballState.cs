using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballState : MonoBehaviour {

    public bool isOn;
    public ParticleSystem fx;
    public GameObject rePos;

    void Start()
    {
        isOn = false;
    }

    IEnumerator Particles()
    {
        fx.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(1.9f);
        fx.Stop();
        gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        gameObject.transform.position = rePos.transform.position;
        isOn = false;

    }

	void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "floor" || other.collider.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ
                                                              | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            StartCoroutine(Particles());
        }
    }
}
