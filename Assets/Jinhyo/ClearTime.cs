using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour
{
    public GameObject pl;
    public GameObject clearUi;
    public Text TimeUi;
    private float timer;
    void Update()
    {
        if (pl.transform.position.y <= -7)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            TimeUi.text = Mathf.Floor((60f - timer) / 60f) + " : " + Mathf.Floor((60f - timer) % 60f);
            if (timer > 60f)
            {
                clearUi.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
