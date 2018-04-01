using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candle : MonoBehaviour {

    public bool isOn;
    public GameObject flame;
    bool flameOn;
    public GameObject UI;

    void Update()
    {
        if(flameOn == true)
        {
            flame.SetActive(true);
        } else
        {
            flame.SetActive(false);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "interactArea")
        {
            UI.SetActive(true);
            if (Input.GetMouseButtonDown(0) && flameOn)
            {
                flameOn = false;
                if (isOn)
                {
                    isOn = false;
                }
                else
                {
                    isOn = true;
                }
            }
            else if (Input.GetMouseButtonDown(0) && !flameOn)
            {
                flameOn = true;
                if (isOn)
                {
                    isOn = false;
                }
                else
                {
                    isOn = true;
                }
            }
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
