using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public static FlowManager instance;
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //���� �ű� �� ������Ʈ�� �����������
        instance = this;

        FlowManager.instance.MoveScene(1);
    }

    public void MoveScene(int index)
    {
        SceneManager.LoadScene(index);
        StartCoroutine(SpawnPlayer());
    }
    
    IEnumerator SpawnPlayer()
    {
        while (true)
        {
            if (player.transform.postion == goal)
            {
                yiled break;
            }
            yield return null;
        }
    }
}
