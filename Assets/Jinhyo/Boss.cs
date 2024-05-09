using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rigid;
    private SpriteRenderer spRen;
    public GameObject pl;
    public GameObject BossFirePos;
    public GameObject bulletfrepab; 
    public GameObject bulletfrepab2;
    public GameObject timeUi;
    Vector2 dir;
    float cuTime = 0;
    float creTime = 1;
    float cuTime2 = 0;
    float creTime2 = 1;
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
        if (pl.transform.position.y <= -7)
        {
            timeUi.SetActive(true);
            rigid.gravityScale = 1;
            cuTime += Time.deltaTime;
            cuTime2 += Time.deltaTime;
            if (cuTime > creTime)
            {
                cuTime = 0;
                GameObject bullet = Instantiate(bulletfrepab);
                bullet.transform.position = BossFirePos.transform.position;
                creTime = UnityEngine.Random.Range(1, 3);
            }
            if (cuTime2 > creTime2)
            {
                cuTime2 = 0;
                GameObject bullet2 = Instantiate(bulletfrepab2);
                bullet2.transform.position = BossFirePos.transform.position;
                creTime2 = UnityEngine.Random.Range(1, 3);
            }
        }
        if (pl.transform.position.x > transform.position.x)
        {
            spRen.flipX = false;
        }
        else spRen.flipX = true;
    }
    private void Jump() 
    {
        if (pl.transform.position.y <= -7)
        {
            rigid.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            dir = (pl.transform.position - transform.position).normalized;
            dir.y = 0;
            rigid.AddForce(dir * Time.deltaTime * 5, ForceMode2D.Impulse);
        }
    }
}
