
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class Hp : MonoBehaviour
{
    [SerializeField] private float maxHp = 100f;
    [SerializeField] private InputAction debugDano;
    [SerializeField] private Image hpBar;
    private float hp;
    
    private void Start()
    {
        hp = maxHp;
        debugDano.Enable(); 
    }

    private void Update()
    {
#if UNITY_EDITOR
        if (debugDano.WasPressedThisFrame())
        {
            TomarDano(15f);
        }
#endif
    }
        

 public void TomarDano(float quantidadeDano)
    {
        Debug.Log("Tomou Dano: " + quantidadeDano);
        hp = hp - quantidadeDano;
        if (hp < 0) hp = 0;

        AttBarraVida();
    }

public void AttBarraVida()
    {
        hpBar.fillAmount = hp / maxHp;
         
    }
    

}
