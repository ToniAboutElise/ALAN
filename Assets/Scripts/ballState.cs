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
            ParticleSystem.MainModule main = fx.GetComponent<ParticleSystem>().main;
            Color startColor = new Vector4(0, 223, 255, 255);
            main.startColor = startColor;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ
                                                              | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            StartCoroutine(Particles());
        } else if (other.collider.tag == "puzzle")
        {
            ParticleSystem.MainModule main = fx.GetComponent<ParticleSystem>().main;
            Color whiteColor = new Vector4(255, 255, 255, 255);
            main.startColor = whiteColor;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ
                                                              | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            StartCoroutine(Particles());
        }

        /*
        ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;
        main.startColor = Color.blue; // <- or whatever color you want to assign
         */

    }
}
