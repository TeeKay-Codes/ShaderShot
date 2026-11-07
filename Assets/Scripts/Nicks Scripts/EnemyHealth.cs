using System;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float health = 40f;
    public event Action OnDeath; // Allows another script to subscribe to the death event of this enemy
    private bool isDead = false;
    public void TakeDamage(float amount)
    {
        if (isDead)
            return;

        health -= amount;

        Debug.Log("Enemy Health: " + health);
        if (health <= 0f)
        {
            isDead = true;
            OnDeath?.Invoke(); //notify WaveSpawner that this enemy has died
            Destroy(gameObject);
        }

    }


    // Update is called once per frame
    void Update()
    {

    }
}
