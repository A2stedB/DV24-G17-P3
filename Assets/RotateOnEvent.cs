using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RotateOnEvent : MonoBehaviour
{
    [SerializeField]
    float openingAmount;
    [SerializeField]
    float openingTime;
    [SerializeField]
    AudioClip openingSound;
    [SerializeField]
    AudioSource soundSource;
    [SerializeField]
    float soundDuration;


    bool open = false;
    public void Open()
    {
        open = true;
        soundSource.clip = openingSound;
        soundSource.Play();
    }
    public void Update()
    {

        if (open)
        {
            soundDuration -= Time.deltaTime;
            gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, new Quaternion(0, 1, 0, openingAmount), openingTime);
            if (soundDuration < 0)
            {
                soundSource.volume -= 0.1f;
                if (soundSource.volume < 0) soundSource.Stop();
            }
        }
        
    }
}
