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
        Debug.Log("시작");
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Debug.Log("Q키 누름");
                if (Physics.Raycast(Hand.transform.position, Hand.transform.forward, out Hit, 15))
                {
                    Debug.Log("무엇가 감지");
                    if (Hit.transform.tag == "holding")
                    {
                        Debug.Log("잡음");
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

