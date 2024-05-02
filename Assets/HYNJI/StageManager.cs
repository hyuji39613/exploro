using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static bool stage1Clear = false;
    public static bool stage2Clear = false;
    public GameObject ui;
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
    public void Stop()
    {
        Time.timeScale = 0;
        ui.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = 1;
        ui.SetActive(false);
    }
    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Stage2")
        {
            stage1Clear = true;
        }
        if (scene.name == "Stage3")
        {
            stage2Clear = true;
            stage1Clear = true;
        }
    }
}
