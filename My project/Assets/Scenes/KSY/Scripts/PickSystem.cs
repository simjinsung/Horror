using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PickSystem : MonoBehaviour
{
    public GameObject Player;
    public bool IsPicking = false;
    private bool IsKeyE = false;
    private bool dontKey = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && dontKey == false)
        {
            IsKeyE = true;
            StartCoroutine(DontKey(0.5f));
        }
       
     }


    private void OnTriggerStay(Collider other)
    {
        if (IsPicking == false)
        {
            if (other.CompareTag("PickAble"))
            {
                if (IsKeyE == true)
                {
                    IsKeyE = false;
                    IsPicking = true;
                    Debug.Log("Àâ´ÂÁß");
                    other.GetComponent<PickObj>().Isholding = true;
                }
            }

        }
    }

    IEnumerator DontKey(float t) {
        dontKey = true;
        yield return new WaitForSeconds(t);
        dontKey = false;
        IsKeyE = false;
        yield return null;
    }

    public void SetIsKeyE(bool b)
    {
        IsKeyE = b;
    }
    public bool GetIsKeyE()
    {
        return IsKeyE;
    }


}
