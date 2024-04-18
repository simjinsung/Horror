using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_position : MonoBehaviour
{
    public static player_position Player;
    // Start is called before the first frame update
   private void Awake()
    {
        Player = this;
    }
}
