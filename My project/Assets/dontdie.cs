using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdie : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
