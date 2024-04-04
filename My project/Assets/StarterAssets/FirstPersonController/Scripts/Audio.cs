using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    IEnumerator abc()
    {
        yield return new WaitForSeconds(10.0f);
        AudioSource audioSource = GetComponent<AudioSource>(); audioSource.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            StartCoroutine(abc());
        }
        
    }


}

