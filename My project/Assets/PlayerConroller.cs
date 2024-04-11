using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConroller : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "enter")
        {
            FlowManager.instance.MoveScene(1);
        }
    }
}
