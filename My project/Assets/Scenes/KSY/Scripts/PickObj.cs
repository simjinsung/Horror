using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Rendering;

public class PickObj : MonoBehaviour
{
    public PickSystem p;
    public GameObject Player;
    public bool PlayerEN = false;
    public int plag = 0;
    public bool holdable = true;
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
            PlayerEN = false;   
    }
   
    void Update()
    {
        var text = transform.GetChild(0);
        if(PlayerEN == true && plag==0) text.gameObject.SetActive(true);
        else if(PlayerEN == false || plag == 1) text.gameObject.SetActive(false);
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
        p.IsPicking = false;
        Isholding = false;
        plag = 0;
    }

   
}
