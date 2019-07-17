using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Combat_Ally : MonoBehaviour
{
    public float hp = 100f;
    public float atkDamage = 25f;



    //Enemy interation

    private float timeBtwAttack;
    public float startTimeBtwAttack = 1f;

    public Transform attackPos; // Posição do ataque
    public LayerMask whatIsEnemy; // O que é inimigo (Quem eu vou atacar)
    public float attackRange = 2f; // Alcance do ataque
    public bool vivo = true; // Variável que verifica se o personagem está vivo ou não


    // Update is called once per frame
    void Update()
    {
        
    }

    void Attack()
    { 
        if (timeBtwAttack <= 0) // Se o tempo entre um ataque e outro for menor ou igual a 0, então vocÊ pode atacar
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemy); // Cria um trigger para verificar quantos inimigos estão na área de contato e coloca todos eles dentro de um vetor Collider

            if (enemiesToDamage.Length > 0) // Se a quantidade de inimigos dentro da área for maior que 0
            {
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                   // enemiesToDamage[i].GetComponent<Enemy>().Kill(); // Mata todos os inimigos que estão na área

                }
            }
        timeBtwAttack = startTimeBtwAttack;
        }            
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }         
        
    }

    void OnDrawGizmosSelected() // Cria um Gizmo na tela apra que seja possivel ver o a área do colisor mesmo quando ele estiver desativado
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
