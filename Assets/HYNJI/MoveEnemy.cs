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


    }
    private void ChangemoveDir()
    {
        moveDir.x = -moveDir.x;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BreakLeft"))
        {
            sprite.flipX = false;
        }
        if (collision.gameObject.CompareTag("BreakRight"))
        {
            sprite.flipX = true;

        }

    }
}
