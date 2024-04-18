using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFollwer : MonoBehaviour
{
    public bool IsStun = false;
    void Update()
    {
        GetComponent<Animator>().SetBool("IsFoundPlayer", true);
        GetComponent<NavMeshAgent>().destination = PlayerManager.Player.transform.position;
        transform.LookAt(PlayerManager.Player.transform.position);
       if(IsStun == false) transform.Rotate(Vector3.up * 90);
        GetComponent<NavMeshAgent>().isStopped = IsStun;
 
        
    }

   /* private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(AttackMotion());
        }
    }*/

    IEnumerator AttackMotion()
    {
        GetComponent<Animator>().SetBool("IsAttackPlayer", true);
        yield return new WaitForSecondsRealtime(1.5f);
        GetComponent<Animator>().SetBool("IsAttackPlayer", false);
        yield break;
    }
}
