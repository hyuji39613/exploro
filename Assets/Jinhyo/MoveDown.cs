using UnityEngine;

public class BlockComponent : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGravityApplied = false;
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
        isGravityApplied = true;
        rb.gravityScale = 1f;
    }
}