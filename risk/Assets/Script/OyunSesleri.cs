using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunSesleri : MonoBehaviour
{
    public AudioClip engel;
    public AudioClip altin;
    public AudioClip top;
    public AudioClip yön;


    /// <summary>
    /// sesleri beğenmedim üzerinde çalış.....................
    /// </summary>

    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void engelSes()
    {
        audioSource.clip = engel;
        audioSource.Play();
    }
    public void altinSes()
    {

        audioSource.clip = altin;
        audioSource.Play();
    }
    public void topSes()
    {

        audioSource.clip = top;
        audioSource.Play();
    }
    public void yönSes()
    {

        audioSource.clip = yön;
        audioSource.Play();
    }
}
