using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class hand : MonoBehaviour
{
    RaycastHit Hit;
    public GameObject Hand;
    bool IsHold = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HandHold());

    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator HandHold()
    {
        Debug.Log("����");
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("QŰ ����");
                if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out Hit, 15))
                {
                    Debug.Log("������ ����");
                    if (Hit.transform.tag == "holding")
                    {
                        Debug.Log("����");
                        StartCoroutine(IsHolding());
                        break;
                    }
                }

            }

            yield return null;
        }
    }
    IEnumerator IsHolding()
    {
        while (true)
        {
            Hit.transform.position = Hand.transform.position;
            yield return null;
        }
    }
}

