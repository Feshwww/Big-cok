using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioSource stepSource;
    [SerializeField] AudioClip step1;
    [SerializeField] AudioClip Voice;
    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshSoco1;
      

        wooshSource.clip = Voice;
        wooshSource.Play();
    }
    public void PlayStep()
    {
        Debug.Log("Play Step");
        stepSource.clip = step1;
        stepSource.Play();
    }
   
}
