using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int currentHealth;

   
    public void TakeDamage(int damage){
        currentHealth -+ damage;
        Debug.Log(" damage TAKEN ");
    } 
} 
