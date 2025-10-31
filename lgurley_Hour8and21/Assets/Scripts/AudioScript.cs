using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AudioToggle();
    }

    void AudioToggle()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (AS.isPlaying == true)
            {
                AS.Stop();
            }
            else
            {
                AS.Play();
            }
        }
    }
}
