using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerFollwer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool("IsFoundPlayer", true);
        GetComponent<NavMeshAgent>().destination = PlayerManager.Player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(AttackMotion());
        }
    }

    IEnumerator AttackMotion()
    {
        GetComponent<Animator>().SetBool("IsAttackPlayer", true);
        yield return new WaitForSecondsRealtime(1.5f);
        GetComponent<Animator>().SetBool("IsAttackPlayer", false);
        yield break;
    }
}
