using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ScoreOnCollisionEnter : MonoBehaviour
{
    public AudioClip sfx;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager.score += 1;
        audioSource.PlayOneShot(sfx);
    }
}
