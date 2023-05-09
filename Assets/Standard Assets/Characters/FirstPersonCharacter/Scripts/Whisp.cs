using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Whisp : MonoBehaviour
{
    public AudioClip soundClip; // The audio clip to play
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(soundClip);
            if(!audioSource.isPlaying){
                Destroy(gameObject);
            }
        }
    }
}
