using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block: MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    void Update()
    {

        if (player.transform.position.x >= transform.position.x - 0.5 &&
            player.transform.position.x <= transform.position.x + 0.5 &&
            player.transform.position.y < transform.position.y )
        {
            Invoke(nameof(BlockMove), 1);
        }
    }
    private void BlockMove()
    {
        rb.gravityScale = 1f;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BlockMove();
        }
    }
}