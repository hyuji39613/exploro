using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    public Camera mainCamera;
    public CinemachineVirtualCamera vCam;

    IEnumerator Start()
    {
        mainCamera = Camera.main;
        yield return null;
        vCam = mainCamera.GetComponent<CinemachineBrain>().ActiveVirtualCamera as CinemachineVirtualCamera;
        print(vCam);
    }

    

    private void Update()
    {
        if (player.transform.position.y <= -7 && mainCamera.orthographicSize < 10)
        {
            vCam.m_Lens.OrthographicSize += 0.01f ;
        }
    }
}
