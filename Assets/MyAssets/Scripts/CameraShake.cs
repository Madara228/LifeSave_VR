using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
using UnityStandardAssets.ImageEffects;
using UnityEngine.SceneManagement;

public class CameraShake : MonoBehaviour
{
    public GameObject _camera;
    private PlayerMovement _playerMovement;
    void Start()
    {
        _playerMovement = GetComponentInParent<PlayerMovement>();
        //StartCoroutine(Drag());

    }
    
    void Update()
    {
        if (_playerMovement.isDead)
        {
            SceneManager.LoadScene("LoseScene");
        }
//        if (Input.GetButtonDown("Jump"))
//        {
//            Debug.Log("shake");
//        }
        
    }
//    public void CameraShaking()
//    {
//        var my_cam = Instantiate(_camera, transform.position, transform.rotation);
//        my_cam.transform.parent=transform;
//        ShakeCameraScript _shakeCameraScript = my_cam.GetComponent<ShakeCameraScript>();
//        _shakeCameraScript.ShakeMyCam();
//        Destroy(my_cam,1.1f);
//    }
//    private IEnumerator Drag()
//    {
//        while (true)
//        {
//            yield return new WaitForSeconds(5f);
//            CameraShaking();                    
//        }
//
//    }
}
