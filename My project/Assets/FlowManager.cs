using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowManager : MonoBehaviour
{
    public static FlowManager instance;
    public GameObject player;
    public GameObject new0;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        DontDestroyOnLoad(gameObject); //씬을 옮길 때 오브젝트가 사라지지않음
        instance = this;

        FlowManager.instance.MoveScene(1);

        }
        
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
            new0 = GameObject.Find("SpawnPoint");
            if (new0 != null)
            {
                break;
            }
            yield return null;
        }

        while (true)
        {
            player.transform.position = new0.transform.position;
            if(player.transform.position == new0.transform.position)
            {
                break;
            }
            yield return null;
        }
    }
}
