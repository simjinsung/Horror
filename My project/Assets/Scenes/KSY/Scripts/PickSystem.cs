using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSystem : MonoBehaviour
{
    public GameObject Player;
    public bool IsPicking = false;
    public bool IsKeyE = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsPicking != true)
        {
          StartCoroutine(GetkeyE());
        }
       
     }


    private void OnTriggerStay(Collider other)
    {
            if (other.CompareTag("PickAble"))
            {
                if(IsKeyE && IsPicking != true)
                {
                    IsPicking = true;
                    Debug.Log("잡는중");
                }
            }
    }

    IEnumerator Picking(Collider obj)
    {
        Debug.Log("잡는중");
        IsPicking = true;
        while (IsKeyE)
        {
            obj.transform.position = Player.transform.position;
            yield return null;
        }
        IsPicking = false;
        yield return null;
    }
    IEnumerator GetkeyE()
    {
        IsKeyE = true;
        yield return new WaitForSecondsRealtime(0.01f);
        IsKeyE = false;
    }

}
