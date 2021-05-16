using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReact : MonoBehaviour
{
    public ReactiveTarget reactiveTarget;

    public Camera newCamera;
    void Start()
    {
        reactiveTarget.react.AddListener(CameraSelect);
    }

    public void CameraSelect()
    {
        CameraOn(newCamera);
        GameModManager.gmm.GameMod = GameMod.Camera;
    }

    public void CameraOn(Camera cameraOn)
    {
        foreach (var camera in Camera.allCameras)
        {
            if(camera == cameraOn)
            {
                camera.enabled = true;
            }
            else
            {
                camera.enabled = false;
            }
        }
    }
}
