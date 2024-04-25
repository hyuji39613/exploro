using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static bool stage1Clear = false;
    public static bool stage2Clear = false;
    public void GotoCh()
    {
        SceneManager.LoadScene("StageCh");
    }
    public void Goto1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void Goto2()
    {
        if (stage1Clear)
        {
            SceneManager.LoadScene("Stage2");
        }   
    }
    public void Goto3()
    {
        if (stage2Clear)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
    public void GotoStart()
    {
        SceneManager.LoadScene("Start");
    }
    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Stage2")
        {
            stage1Clear = true;
        }
    }
}
