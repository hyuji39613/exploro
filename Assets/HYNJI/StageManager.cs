using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public void GameScensCtrl()
    {
        SceneManager.LoadScene("Stage1");
        Debug.Log("StartGame");
    }
    
}
