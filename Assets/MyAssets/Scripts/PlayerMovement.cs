using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Transform _camera;
    [SerializeField]public bool isDead = false;
    private Rigidbody rb;
    private int score = 0;
    public GameObject block;
    void Start()
    {
        _camera = GetComponentInChildren<Camera>().transform;
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && isDead == false)
      //  if(_camera.eulerAngles.x>30f && _camera.eulerAngles.x<90f)
        {
            Vector3 moveForward = _camera.TransformDirection(Vector3.forward);
            transform.position += moveForward*Time.deltaTime * speed*Time.deltaTime;
         //   Debug.Log(transform.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flame")
        {
            isDead = true;
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void PlatokTrigger()
    {
        score += 1;
        GameObject platok = GameObject.Find("Platok");
        block.SetActive(true);
        Destroy(platok);
    }

    
}