using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject pl;
    private void Update()
    {
        if (pl.transform.position.y <= -7)
        {
            Camera.main.orthographicSize = 10;
        }
    }
}
