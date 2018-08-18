using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HandMove : MonoBehaviour
{
    Ray nmyRay;
    public Transform Alan;
    bool killHim;
    RaycastHit rayHit;
    public float distance;
    float distanceBodies;

    void Start()
    {
       
        killHim = false;

    }

    void FixedUpdate()
    {
        
        distanceBodies = Vector3.Distance(transform.position, Alan.transform.position);
        Debug.Log(distanceBodies);
        //Debug.Log("one");
        if (distanceBodies < distance)
        {
            //Debug.Log("player detected");
            killHim = true;

        }

        if (killHim == true)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = Alan.transform.position;
        }

    }
}
