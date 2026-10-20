using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

using UnityEngine.InputSystem;
public class luta : MonoBehaviour
{
    [SerializeField] private Animator animatorluta;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction correndo;


    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;
        correndo.Enable();
        correndo.performed += Correr;
        correndo.canceled -= Correr;
    }

    private void Correr(InputAction.CallbackContext context)
    {
      
            Debug.Log("aaaaaaa");
            animatorluta.SetBool("Walk Forward", true);
        
       
    }

    private void OnDestroy()
    {
        ataque.performed -= Atacar;
        
    }

    public void Atacar(InputAction.CallbackContext context)
    {
        animatorluta.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }
}
