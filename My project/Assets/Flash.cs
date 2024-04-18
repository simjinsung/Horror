using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flash : MonoBehaviour
{
    bool PlayerGetLight; //true�� ��� ������on
    Light myLight; //light ������Ʈ�� ��� ����

    void Start()
    {
        PlayerGetLight = false; //�ʱ⿡�� �������� �Һ��� ���� ����
        myLight = GetComponent<Light>(); //������Ʈ�� ���� light ������Ʈ�� ������.
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!PlayerGetLight)
            {
                PlayerGetLight = true; //FŰ�� ���� �������� �Һ��� on/off
            }
            else
            {
                PlayerGetLight = false;
            }
        }

        if (PlayerGetLight == false)
        {
            myLight.intensity = 0; //������ off
        }


        if (PlayerGetLight == true)
        {
            myLight.intensity = 500; //������ on
        }

    }
}