using UnityEngine;

public class pLAYERSCO : MonoBehaviour
{
    [SerializeField] private ParticleSystem soco;
    public void PlaySocoParticula()
    {
        soco.Play();
    }

}