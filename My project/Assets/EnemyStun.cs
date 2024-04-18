using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class EnemyStun : MonoBehaviour
{
    public HandLight GameSystem;
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            GameSystem.stuntime = 5.0f;
        }
    }
}
