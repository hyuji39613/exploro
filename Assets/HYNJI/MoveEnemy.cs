using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private Vector3 moveDir;
    public float speed;
    private Rigidbody2D rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(ChangemoveDir), 2, 4);
        moveDir.x = 1;
    }
    void Update()
    {
        transform.position += moveDir * speed * Time.deltaTime;
    }
    private void ChangemoveDir()
    {
        moveDir.x = -moveDir.x;
    }
    
}
