using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeIn : MonoBehaviour {

    public Image image;
    public float minus;
    public float coroutineTime;
    public float actCharacterTime;
    public GameObject Character;
    bool alpha;

    void Start()
    {
        alpha = false;
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "interactArea")
        {
            Character.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
            alpha = true;
        }
    }

    void Update()
    {
        if (image.color.a != 1 && alpha == true)
        {
            image.color = new Color(image.color.r, image.color.b, image.color.g, image.color.a + minus);
        }
    }
}
