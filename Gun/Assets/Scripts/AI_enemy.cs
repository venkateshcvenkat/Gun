using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_enemy : MonoBehaviour
{
    public Transform target;
    public  NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
