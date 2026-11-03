using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class audio : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioSource stepSource;
    [SerializeField] AudioClip step1;
    [SerializeField] AudioClip Voice;
    [SerializeField] List<AudioClip> grunts;
    [SerializeField] AudioSource voiceSource;

    [SerializeField] List<AudioClip> Steps;

    [SerializeField] AudioSource StepSource;

    [SerializeField] List<AudioClip> Step2;

    [SerializeField] AudioSource Step2Source;
    public void PlayWoosh()
    {
        Debug.Log("Play woosh");
        wooshSource.clip = wooshSoco1;
      


        wooshSource.Play();

        voiceSource.clip = grunts[Random.Range(0,grunts.Count)];

        voiceSource.pitch = Random.Range(0.9f, 1.1f);

        voiceSource.Play();
    }
    public void PlayStep()
    {
        Debug.Log("Play Step");
        stepSource.clip = step1;
        stepSource.Play();

        StepSource.clip = Steps[Random.Range(0, Steps.Count)];

        StepSource.pitch = Random.Range(0.9f, 1.1f);

        StepSource.Play();
    }

    public void PlayVoice()
    {
        
    }

    public void PlayStep2()
    {


        Step2Source.clip = Step2[Random.Range(0, Step2.Count)];

        Step2Source.pitch = Random.Range(0.9f, 1.1f);

        Step2Source.Play();

    }
}
