using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;
    public int damage;
   // public GameObject bloodEffect;
    
    void Update(){
        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage){
        //Instantiate(bloodEffect, transform.position, Quaternion.identity);
        currentHealth -= damage;
        Debug.Log(" damage TAKEN ");
    } 
} 
