using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Healthbar healthbarScript;
    public float PHealth = 100f;
    public float enemyDam = 5f;
    void Update()
    {
        PHealth = healthbarScript.health;
        if (PHealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(4);
        }
    }
    void OnTriggerEnter(Collider rigidbody)
    {
        if (rigidbody.gameObject.tag == "Enemy")
        {
            healthbarScript.health -= enemyDam;
        }

    }
}
