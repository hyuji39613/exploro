using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public void GotoCh()
    {
        SceneManager.LoadScene("StageCh");
        Debug.Log("StartGame");
    }
    public void Goto1()
    {
        SceneManager.LoadScene("Stage1");
        Debug.Log("StartGame");
    }
    public void Goto2()
    {
        SceneManager.LoadScene("Stage2");
        Debug.Log("StartGame");
    }
    public void Goto3()
    {
        SceneManager.LoadScene("Stage3");
        Debug.Log("StartGame");
    }
    public void GotoStart()
    {
        SceneManager.LoadScene("Start");
        Debug.Log("StartGame");
    }
}
