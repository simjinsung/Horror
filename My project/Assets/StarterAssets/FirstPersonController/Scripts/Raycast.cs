using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject);
                if(hit.transform.tag == "box")
                {
                    hit.transform.position = gameObject.transform.position + new Vector3(1, 0, 0);
                }
            }
        }
    }
   
}
