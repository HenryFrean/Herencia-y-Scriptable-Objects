using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumper : Enemy
{
    [SerializeField]
    [Range(1f, 100f)]
    private float jumpForce = 10f;

    private Rigidbody rbEnemy = null;

    private void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();
        InvokeRepeating("jumpEnemy", 0f, 2f);
    }
    private void jumpEnemy()
    {
        rbEnemy.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
