using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class CameraShake : MonoBehaviour
{
    public GameObject _camera;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            CameraShaking();
            Debug.Log("shake");
        }
    }
    public void CameraShaking()
    {
        var my_cam = Instantiate(_camera, transform.position, Quaternion.identity);
        ShakeCameraScript _shakeCameraScript = my_cam.GetComponent<ShakeCameraScript>();
        _shakeCameraScript.ShakeMyCam();
        Destroy(my_cam,1.1f);
    }
}
