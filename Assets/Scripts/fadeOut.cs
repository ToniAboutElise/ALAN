using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeOut : MonoBehaviour {

    public Image image;
    public float minus;
    public float coroutineTime;
    public float actCharacterTime;
    public GameObject Character;
    bool alpha;

    void Start()
    {
        alpha = false;
        StartCoroutine(fadeNow());
        Character.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = false;
    }

    IEnumerator fadeNow()
    {
        yield return new WaitForSeconds(coroutineTime);
        alpha = true;
        yield return new WaitForSeconds(actCharacterTime);
        Character.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
        StopCoroutine(fadeNow());
    }

    IEnumerator lockBool()
    {
        yield return new WaitForSeconds(5);
        alpha = false;
        StopCoroutine(lockBool());
    }

    void Update()
    {
     if(image.color.a != 0 && alpha == true)
        {
            image.color = new Color(image.color.r, image.color.b, image.color.g, image.color.a - minus);
            StartCoroutine(lockBool());
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
