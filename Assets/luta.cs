using UnityEngine;

using UnityEngine.InputSystem;
public class luta : MonoBehaviour
{
    [SerializeField] private Animator animatorluta;
    [SerializeField] private InputAction ataque;

    
    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;
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
