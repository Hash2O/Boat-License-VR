using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumKitManager : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        //float pitch = Random.Range(0.1f, 2f);
        //_audioSource.pitch = pitch;
        _audioSource.Play();
    }
}
