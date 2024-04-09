using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveDir = Vector2.zero;
    public float jumpScale = 5f;
    public float speed;
    private bool canJump = true;
    private Rigidbody2D rb;
    public float jumpDelay = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
            Invoke(nameof(SetCanJump), jumpDelay);
        }
    }

    private void SetCanJump()
    {
        canJump = true;
    }
}