using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

using UnityEngine.InputSystem;
public class luta : MonoBehaviour
{
    [SerializeField] private Animator animatorluta;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction correndo;
    [SerializeField] private InputAction atras;


    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;
        correndo.Enable();
        atras.Enable();
        //nome da ação |tipo event|atrib|
        correndo.performed += Frenteir;
        atras.performed += atrasir;
        atras.canceled += atrasparar;


        correndo.canceled += Frenteparar;
    }

    private void Frenteir(InputAction.CallbackContext context)
    {

        Debug.Log("aaaaaaa");
        animatorluta.SetBool("Walk Forward", true);

    }
    private void Frenteparar(InputAction.CallbackContext context)
    {
        animatorluta.SetBool("Walk Forward", false);

    }
    private void atrasir(InputAction.CallbackContext context)
    {
        animatorluta.SetBool("Walk Backward", true);
    }
    private void atrasparar(InputAction.CallbackContext context)
    {
        animatorluta.SetBool("Walk Backward", false);
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
