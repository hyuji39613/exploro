using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveDir = Vector2.zero;
    public float jumpScale = 5f;
    public float speed;
    private bool canJump = true;
    private Rigidbody2D rb;
    public Animator anim;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        moveDir = new Vector2(h, 0);
        transform.position += (Vector3)moveDir * speed * Time.deltaTime;

        if (h != 0)
        {
            if (h < 0)
            {
                sprite.flipX = false;
                anim.SetBool("Move", true);
            }
            else
            {
                sprite.flipX = true;
                anim.SetBool("Move", true);
            }
        }
        else anim.SetBool("Move", false);
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            rb.AddForce(Vector2.up * jumpScale, ForceMode2D.Impulse);
            Debug.Log("Jump");
            anim.SetBool("Jump", true);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetTrigger("Map");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            rb.AddForce(Vector2.up * jumpScale / 2, ForceMode2D.Impulse);
            canJump = false;
        }
        else if (collision.gameObject.CompareTag("Map"))
        {
            
        }
        else
        {
            Debug.Log("Collision");
            canJump = true;
            anim.SetBool("Jump", false);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            
        }
        else
        {
            Debug.Log("CollisionStay");
            canJump = true;
            anim.SetBool("Jump", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
           
        }
        else
        {
            Debug.Log("CollisionExit");
            canJump = false;
            anim.SetBool("Jump", true);
        }
    }
}