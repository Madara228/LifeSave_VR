using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ShakeCameraScript : MonoBehaviour
{
    public void ShakeMyCam()
    {
        CameraShaker.Instance.ShakeOnce(4f, 4f, .1f, 1f);
    }
}