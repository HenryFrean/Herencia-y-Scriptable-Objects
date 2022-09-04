using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected EnemyData enemyData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Attack();
    }
    protected virtual void Move()
    {
        transform.Translate(Vector3.forward * enemyData.speed * Time.deltaTime);
    }
    public void Attack()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, enemyData.rangeAttack))
        {
            if(hit.transform.CompareTag("Player"))
            {
                Debug.Log("ATACANDO AL PLAYER");
            }
        }
    }
    public void DrawRaycast()
    {
        Gizmos.color = Color.red;
        Vector3 directionRay = transform.TransformDirection(Vector3.forward) * enemyData.rangeAttack;
        Gizmos.DrawRay(transform.position, directionRay);
    }
    private void OnDrawGizmos()
    {
        DrawRaycast();
    }
}
