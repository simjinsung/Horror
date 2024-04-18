using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monter : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Animator>().SetBool("IsRun", true);
        GetComponent<NavMeshAgent>().destination = player_position.Player.transform.position;
    }
}
