using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerConroller : MonoBehaviour
{
    public Image blindImg;
    private void Awake()
    {
        //raycasthit�̸�.transform.gameObject
        blindImg.color = new Color(0, 0, 0, 1);
    }

    //IEnumerator SetBlind()
    //{
    //    for (int i = 0; i < 100; i++)
    //    {
    //        blindImg.color = new Color(0, 0, 0, i/100);
    //        Physics.Raycast

    //        yield return null;
    //    }
    //}
}
