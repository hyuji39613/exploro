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

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            rb.AddForce(Vector2.up * jumpScale, ForceMode2D.Impulse);
            Debug.Log("Jump");
            anim.SetBool("Jump", true);
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sprite.flipX = false;
            anim.SetBool("Move", true);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            sprite.flipX = true;
            anim.SetBool("Move", true);
        }
        

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
            anim.SetBool("Jump", false);
        }
        else
        {
            Debug.Log("Collision");
            canJump = true;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            anim.SetBool("Jump", false);
        }
        else
        {
            Debug.Log("CollisionStay");
            canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            anim.SetBool("Jump", false);
        }
        else
        {
            Debug.Log("CollisionExit");
            canJump = false;
        }
    }
}