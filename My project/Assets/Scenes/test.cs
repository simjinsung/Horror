using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    bool IsMusicStart = false;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Coroutinetest());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Coroutinetest()
    {
        Debug.Log("test");
        while (true)
        {
            if (IsMusicStart == true)
            {
                Debug.Log("test");
                audioSource.Play();
                yield return new WaitForSecondsRealtime(10);
                audioSource.Stop();
                break;
            }
            yield return null;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "place")
        {
            Debug.Log(IsMusicStart);
            IsMusicStart = true;
        }

    }
}
