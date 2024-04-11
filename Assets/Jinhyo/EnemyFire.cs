using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject firePos;
    public float ThrowDelay = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Fire), ThrowDelay, ThrowDelay);
    }

    
    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = firePos.transform.position;
    }
}
