using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    Transform Player;
    float RotationSpeed=3.0f;
    public float MoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), RotationSpeed*Time.deltaTime);
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;
    }
}
