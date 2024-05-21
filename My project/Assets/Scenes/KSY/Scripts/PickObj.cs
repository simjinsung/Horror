using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickObj : MonoBehaviour
{
    public PickSystem p;
    public GameObject Player;
    private int plag = 0;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (p.IsPicking && plag == 0)
        {
            plag = 1;
            transform.SetParent(Player.transform);
            transform.localPosition = Vector3.zero;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            GameObject item = Player.GetComponentInChildren<Rigidbody>().gameObject;
            Rigidbody itemRigidbody = item.GetComponent<Rigidbody>();
            itemRigidbody.isKinematic = false;
            Debug.Log("물건 잡힘");
            
        } else if(p.IsPicking && p.IsKeyE && plag == 1)
        {
            GameObject item = Player.GetComponentInChildren<Rigidbody>().gameObject;
            Rigidbody itemRigidbody = item.GetComponent<Rigidbody>();
            Debug.Log("놓음");
            plag = 0;
            itemRigidbody.isKinematic = true;
            Player.transform.DetachChildren();
            p.IsPicking = false;
           
        }
    }
}
