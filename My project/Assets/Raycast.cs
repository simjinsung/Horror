using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Raycast : MonoBehaviour
{
    public float lineSize = 16f;
    public Image png;
    public IEnumerator Blind()
    {
        Color tempColor = png.color;
        for (float i = 0; i <= 1.1; i+=0.1f)
        {
            tempColor.a = i;
            png.color = tempColor;
            yield return null;           
        }
        
    }
    void Update()
    {
        
        Debug.DrawRay(transform.position, transform.forward * lineSize, Color.yellow);

        if(Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, lineSize))
            {
                Debug.Log(hit.collider.gameObject.name);
                if(hit.transform.tag == "tree")
                {
                    StartCoroutine("Blind");
                }
            }
            
        }
    }
}