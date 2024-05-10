using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour
{
    public GameObject pl;
    public GameObject clearUi;
    public GameObject overUi;
    public Text TimeUi;
    private float timer;
    void Update()
    {
        if (pl.transform.position.y <= -7 )
        {
            timer += Time.deltaTime;
            TimeUi.text = "time : "+ Mathf.Floor((30f - timer));
            if (timer >= 29f)
            {
                clearUi.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
