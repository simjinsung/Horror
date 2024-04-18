using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player_Tracking : MonoBehaviour
{
    private Transform playertr;
    private void Start()
    {
        playertr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        
    }
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = playertr.position;
    }
}
