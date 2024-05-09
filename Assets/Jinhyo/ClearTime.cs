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
        if (pl.transform.position.y <= -7 && overUi.active != true)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            TimeUi.text = "time : "+ Mathf.Floor((30f - timer));
            if (timer > 29f)
            {
                clearUi.SetActive(true);
                Time.timeScale = 0;
            }
            else if (overUi.active == true)
            {
            }
        }
    }
}
