using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   private float timeBtwAttack;
   public float startTimeBtwAttack;
    public Animator canAnim;
    public Animator playerAnim;
   public Transform attackPos;
   public LayerMask whatIsEnemies;
   public float attackRange;
   public int damage;
    public float attackMove;
    
        void Update()
        {
            
            if(timeBtwAttack <= 0){
                // The time between swings
                if(Input.GetKey(KeyCode.Mouse0)){
                   // canAnim.SetTrigger("shake");
                   // playerAnim.SetTrigger("attack");
                    Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                    timeBtwAttack = startTimeBtwAttack;
                }
            }
            } else {
                timeBtwAttack -= Time.deltaTime;
            }   

           
        }
         void OnDrawGizmosSelected(){
                
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(attackPos.position, attackRange);
            }
} 
