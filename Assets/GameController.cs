using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 startPos;

    private void ()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.CompareTag("Enemy")) 
    {
        Die();
    }
}
    
    void Die()
{
    Respawn();
}
    void Respawn()
{
    transform.position = startPos;
    }
}
