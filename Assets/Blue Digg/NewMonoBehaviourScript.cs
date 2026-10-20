using System;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator animatorlutador;
    [SerializeField] private InputAction andar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        andar.Enable();  
    }

    // Update is called once per frame
    void Update()
    {
        if (andar.IsPressed())
        {
            Debug.Log("andando");
            animatorlutador
        }    
    }
}
