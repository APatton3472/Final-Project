using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;
   
    public GameObject impactEffect1;

    void Update()
    {
        
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        GameObject impactGO1 = Instantiate(impactEffect1,transform.position,transform.rotation);
        Destroy(impactGO1, 0.5f);
        EnemyTotalCount.EnemiesKilled += 1;
    }
    
}
