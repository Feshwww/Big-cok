using UnityEngine;

public class sonsaudio : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;

    public void PlayWoosh()
    {
        Debug.Log("Play Woosh");
        wooshSource.clip = wooshSoco1;

        wooshSource.Play();
    }
}
