using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TextControl : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Rotate(0, 180, 0);
    }


}