using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 moveDir;
    public float speed;
    private bool canJump = true;
    private Rigidbody2D rigid;
    [SerializeField] private float jumpHeight;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        moveDir = new Vector3(h, 0, 0);
        transform.position += moveDir * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {   
            Destroy(gameObject);

        }
       
    }
}
