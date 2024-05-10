using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFirep : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePos;
    public float throwDelay = 1f;
    public float startDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Fire), startDelay, throwDelay);
    }

    
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = firePos.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(transform.gameObject);
        }
    }
}
