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
        nmyRay = new Ray(transform.position, transform.forward * distance);
        Debug.DrawLine(transform.position, transform.forward * distance, Color.red);
        distanceBodies = Vector3.Distance(transform.position, Alan.transform.position);
        print(distanceBodies);
       
        if(Physics.Raycast(nmyRay, out rayHit)) { 
            if (distanceBodies < distance && rayHit.collider.gameObject.tag != "wall")
            {
                killHim = true;
            }
        }
        if (killHim == true)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = Alan.transform.position;
        }

    }
}
