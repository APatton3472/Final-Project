using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyTotalCount : MonoBehaviour
{
    public static int EnemiesKilled = 0;
    public int ek;
    public int MaxKilled = 15;
    public int nextlevel = 2;

    private void Start()
    {
        ek = 0;
    }
    void Update()
    {
        ek = EnemiesKilled;
        if (EnemiesKilled >= MaxKilled)
        {
            Cursor.lockState = CursorLockMode.None;
            ek = 0;
            SceneManager.LoadScene(nextlevel);
        }
    }
}
