using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeEmissive : MonoBehaviour {
    public bool changedEmissive;

    void Start()
    {
        changedEmissive = false;
    }
	
    void EntersEmissiveColor()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        //rend.material.SetColor("__MainColor", Color.white);
        //rend.material.SetColor("__EmissiveColor", Color.white);
        rend.material.SetFloat("_Shininess", 0f);
        changedEmissive = true;
    }

    void ExitsEmissiveColor()
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        //rend.material.SetColor("__MainColor", Color.red);
        //rend.material.SetColor("__EmissiveColor", Color.white);
        rend.material.SetFloat("_Shininess", 1f);
        changedEmissive = false;
    }

    void OnTriggerEnter (Collider other) {
		if(other.tag == "puzzle")
        {
            EntersEmissiveColor();
        }
	}

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "puzzle")
        {
            ExitsEmissiveColor();
        }
    }
}
