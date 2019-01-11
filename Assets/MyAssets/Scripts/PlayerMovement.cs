using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Transform _camera;
    private Rigidbody rb;

    void Start()
    {
        _camera = GetComponentInChildren<Camera>().transform;
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}