using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandLight : MonoBehaviour
{
    public GameObject Light;
    public PlayerFollwer Enemy;
    public int turnlight = 0;
    public float stuntime = 0f;

    private void Start()
    {
        StartCoroutine(StunSystem());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            Debug.Log("FÅ° ´©¸§");
            StartCoroutine(Islighton());
        }
    }

    IEnumerator Islighton()
    {
        turnlight++;
        if (turnlight == 1)
        {
            Light.SetActive(false);
            Debug.Log("¼ÕÀüµî ²¨Áü");
        }
        else if (turnlight == 2)
        {
            turnlight = 0;
            Light.SetActive(true);
            Debug.Log("¼ÕÀüµî ÄÑÁü");
        }
        yield return null;
    }

    public IEnumerator StunSystem()
    {
        while (true)
        {
            if (stuntime >= 1.0f)
            {
                Enemy.IsStun = true;
                Enemy.GetComponent<Animator>().SetBool("Stuning", true);
                stuntime -= 1.0f;
            }
            else if (stuntime <= 0f)
            {
                Enemy.IsStun = false;
                Enemy.GetComponent<Animator>().SetBool("Stuning", false);
            }
            if (stuntime >= 1.0f) { 
            yield return new WaitForSecondsRealtime(1.0f);
            }
            yield return null;
        }
    }

}
