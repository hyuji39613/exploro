using UnityEngine;

public class BlockComponent : MonoBehaviour
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
            BlockMove();
        }
    }
    private void BlockMove()
    {
        rb.gravityScale = 0.9f;
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(BlockMove), 0.2f);
        }
    }
}