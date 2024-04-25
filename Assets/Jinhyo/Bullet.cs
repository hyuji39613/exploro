using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject GameOverUi;
    public bool isGoLeft = true;    
    public float speed = 5f;
    public GameObject Parent;
    
    // Update is called once per frame
    void Update()
    {
        if (isGoLeft)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else transform.position += Vector3.right * speed * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameOverUi.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                
            }
            else Destroy(gameObject);
        }
    }
}
