using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flash : MonoBehaviour
{
    bool PlayerGetLight; //true일 경우 손전등on
    Light myLight; //light 컴포넌트를 담는 변수

    void Start()
    {
        PlayerGetLight = false; //초기에는 손전등의 불빛이 꺼진 상태
        myLight = GetComponent<Light>(); //오브젝트가 가진 light 컴포넌트를 가져옴.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!PlayerGetLight)
            {
                PlayerGetLight = true; //F키를 눌러 손전등의 불빛을 on/off
            }
            else
            {
                PlayerGetLight = false;
            }
        }

        if (PlayerGetLight == false)
        {
            myLight.intensity = 0; //손전등 off
        }


        if (PlayerGetLight == true)
        {
            myLight.intensity = 500; //손전등 on
        }

    }
}