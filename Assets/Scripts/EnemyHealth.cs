using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 1f;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
}
