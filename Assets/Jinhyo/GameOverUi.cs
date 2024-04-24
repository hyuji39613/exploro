using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUi : MonoBehaviour
{
    public void Awake()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }

}
