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

    void Update()
    {
        ek = EnemiesKilled;
        if (EnemiesKilled >= MaxKilled)
        {
            SceneManager.LoadScene(nextlevel);
        }
    }
}
