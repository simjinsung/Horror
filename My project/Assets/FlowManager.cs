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
        DontDestroyOnLoad(gameObject); //씬을 옮길 때 오브젝트가 사라지지않음
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
