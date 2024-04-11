using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public static FlowManager instance;
    public GameObject player;
    GameObject new0;
    // Start is called before the first frame update

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //���� �ű� �� ������Ʈ�� �����������
        instance = this;
        
         
    }
   
    public void MoveScene(int index)
    {
        SceneManager.LoadScene(index);
        StartCoroutine(SetPosision());
    }
    
        
    IEnumerator SetPosision()
    {
        while (true)
        {
            new0 = GameObject.Find("Spawn");
            if(new0 != null)
            {
                yield return StartCoroutine(SpawnPlayer());
                break;
            }
            yield return null;
        }
        
    }
    IEnumerator SpawnPlayer()
    {
        while(true)
        {
            player.transform.position = new0.transform.position;
            if(player.transform.position == new0.transform.position){
                break;
            }
            yield return null;
        }
        
    }
}
