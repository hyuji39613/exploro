using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rigid;
    private SpriteRenderer spRen;
    public GameObject Pl;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spRen = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(Jump),2,2);
    }
    void Update()
    {
        if (Pl.transform.position.y <= -7)
        {
            rigid.gravityScale = 1;
            
        }
        if (Pl.transform.position.x - transform.position.x < 0)
        {
            spRen.flipX = true;
        }
        else spRen.flipX = false;

    }
    private void Jump() 
    {
        if (Pl.transform.position.y <= -7)
        {
            rigid.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }
    }
}
