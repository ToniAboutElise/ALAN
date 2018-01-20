using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoMovement : MonoBehaviour {

    public GameObject target;

    public bool move;
    public bool rotate;
    public bool scale;

    public int xMove;
    public int yMove;
    public int zMove;
    public int xRotate;
    public int yRotate;
    public int zRotate;
    public int xScale;
    public int yScale;
    public int zScale;

    /*
    public int xMoveMax;
    public int xMoveMin;

    public int xRotateMax;
    public int xRotateMin;

    public int xScaleMax;
    public int xScaleMin;
    */


    void Update () {
        if (move)
        {
            target.transform.position.Set(xMove * Time.deltaTime, yMove * Time.deltaTime, zMove * Time.deltaTime);
        }

        if (rotate)
        {
            target.transform.Rotate(xRotate * Time.deltaTime, yRotate * Time.deltaTime, zRotate * Time.deltaTime);
        }

        if (scale)
        {
            target.transform.localScale.Set(xScale * Time.deltaTime, yScale * Time.deltaTime, zScale * Time.deltaTime);
        }
	}
}
