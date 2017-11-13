using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actOnCoroutine : MonoBehaviour {


    public GameObject[] buttons;
    public bool isPlaying;
    public GameObject PanelToAct;
    public GameObject PanelToDisact;
    public Animation anim;

    void Start()
    {
        isPlaying = true;
       StartCoroutine(actAndAnim());
    }

    void Update()
    {
        if (!isPlaying)
        {
            foreach(GameObject go in buttons)
            {
                go.GetComponent<Button>().enabled = true;
            }
        }
    }

    IEnumerator actAndAnim()
    {
        yield return new WaitForSeconds(19);
        PanelToDisact.SetActive(false);
        PanelToAct.SetActive(true);
        anim.Play("buttonsUp");
        isPlaying = false;
        Destroy(this);

    }   

}
