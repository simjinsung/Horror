using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PickObj : MonoBehaviour
{
    public PickSystem p;
    public GameObject Player;
    private bool PlayerEN = false;
    private int plag = 0;
    private bool holdable = true;
    public bool Isholding = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PickSystem"))
        {
            PlayerEN = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.transform.CompareTag("PickSystem"))
        {
            PlayerEN = false;
        }
    }
   
    void Update()
    {
        if (holdable && Isholding)
        {
            if (plag == 0 && PlayerEN)
            {
               
                plag = 1;
                transform.SetParent(Player.transform);
                GameObject item = Player.GetComponentInChildren<Rigidbody>().gameObject;
                Rigidbody itemRigidbody = item.GetComponent<Rigidbody>();
                transform.localPosition = Vector3.zero;
                transform.rotation = new Quaternion(0, 0, 0, 0);
                p.SetIsKeyE(false);
                itemRigidbody.isKinematic = true;
                Debug.Log("물건 잡힘");
            }
            else if (p.GetIsKeyE() == true && plag == 1)
            {
                GameObject item = Player.GetComponentInChildren<Rigidbody>().gameObject;
                Rigidbody itemRigidbody = item.GetComponent<Rigidbody>();
                Debug.Log("놓음");
                itemRigidbody.isKinematic = false;
                Player.transform.DetachChildren();
                StartCoroutine(Cooltime(0.5f));

            }
        }
    }

    IEnumerator Cooltime(float t)
    {
        holdable = false;
        yield return new WaitForSeconds(t);
        holdable = true;
        p.SetIsKeyE(false);
        Isholding = false;
        plag = 0;
    }

   
}
