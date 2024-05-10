using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public static bool stage1Clear = false;
    public static bool stage2Clear = false;
    public GameObject ui;
    private bool soundOn = true;
    public GameObject voOn;
    public GameObject voOff;
    public GameObject stop;
    public GameObject resume;
    public AudioSource bgm;

    
    private void Awake()
    {
        bgm = GetComponentInChildren<AudioSource>();
    }
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
        stop.SetActive(false);
        resume.SetActive(true);
        bgm.Pause();

    }
    public void Resume()
    {
        Time.timeScale = 1;
        ui.SetActive(false);
        resume.SetActive(false);
        stop.SetActive(true);
        bgm.Play();

    }
    public void SoundChange()
    {
        if (soundOn) 
        {
            voOn.SetActive(false);
            voOff.SetActive(true);
           
        }
        else
        {
            voOn.SetActive(true);
            voOff.SetActive(false);
            bgm.Play();
        }
        soundOn = !soundOn;
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
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

        if(Time.timeScale == 0)
        {
            bgm.Stop();
        }
    }
}
