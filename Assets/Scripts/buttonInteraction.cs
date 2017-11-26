using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonInteraction : MonoBehaviour {

    public Button btn1;
    public Button btn2;
    public Button btn3;
    public Button btn4;
    public Button btnRestart;
    bool isClicked1;
    bool isClicked2;
    bool isClicked3;
    bool isClicked4;
    int buttonsPressed;
    public AudioSource wrong;
    public AudioSource restart;
    public AudioSource solved;


    void Start () {
        isClicked1 = false;
        isClicked2 = false;
        isClicked3 = false;
        isClicked4 = false;
        buttonsPressed = 0;
    }
	

	void Update () {
        btn1.onClick.AddListener(clicked1);
        btn2.onClick.AddListener(clicked2);
        btn3.onClick.AddListener(clicked3);
        btn4.onClick.AddListener(clicked4);
        btnRestart.onClick.AddListener(restartAll);

        if(isClicked1 && isClicked2 && isClicked3 && isClicked4)
        {
            //DO THE OBJECT ANIMATION. I NEED A PUBLIC OBJECT AND A PUBLIC ANIM SO I CAN SELECT'EM DIRECTLY FROM THE UNITY INSPECTOR
        }
    }

    void restartAll()
    {
        restart.Play();
        isClicked1 = false;
        isClicked2 = false;
        isClicked3 = false;
        isClicked4 = false;
    }

    void clicked1()
    {
        if(!isClicked2 && !isClicked3 && !isClicked4) { 
            isClicked1 = true;
        }else
        {
            isClicked1 = false;
            isClicked2 = false;
            isClicked3 = false;
            isClicked4 = false;
        }
    }

    void clicked2()
    {
        if (isClicked1 && !isClicked3 && !isClicked4)
        {
            isClicked2 = true;
        }else
        {
            isClicked1 = false;
            isClicked2 = false;
            isClicked3 = false;
            isClicked4 = false;
        }
    }

    void clicked3()
    {
        if (isClicked1 && isClicked2 && !isClicked4)
        {
            isClicked3 = true;
        }else
        {
            isClicked1 = false;
            isClicked2 = false;
            isClicked3 = false;
            isClicked4 = false;
        }
    }

    void clicked4()
    {
        if (isClicked1 && isClicked2 && isClicked3)
        {
            isClicked4 = true;
        }else
        {
            isClicked1 = false;
            isClicked2 = false;
            isClicked3 = false;
            isClicked4 = false;
        }
    }
}
