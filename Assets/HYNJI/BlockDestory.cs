using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestory : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(BlockDel), 1);
        }
    }
    private void BlockDel()
    {
        Destroy(gameObject);
    }
}
