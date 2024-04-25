using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private Vector3 moveDir;
    public float speed;
    public float moTime;
    private Rigidbody2D rigid;
    private SpriteRenderer sprite;
    int flipCount = 0;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        InvokeRepeating(nameof(ChangemoveDir), moTime, moTime);
        moveDir.x = 1;
    }
    void Update()
    {
        transform.position += moveDir * speed * Time.deltaTime;
        if (flipCount % 2 == 0)
        {
            sprite.flipX = false;
        }
        else sprite.flipX = true;

    }
    private void ChangemoveDir()
    {
        moveDir.x = -moveDir.x;
        flipCount++;
        
    }
    
}
