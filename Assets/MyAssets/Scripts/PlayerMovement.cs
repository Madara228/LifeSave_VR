using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Transform _camera;
    [SerializeField]public bool isDead = false;
    private Rigidbody rb;
    private int score = 2;
    public GameObject block;
    public AudioSource[] audioSources;
    public GameObject winText;
    public GameObject texter;
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
        else if (other.gameObject.tag == "Escape")
        {
           win();
        }
    }
    

    public void PlatokTrigger()
    {
        score += 1;
        GameObject platok = GameObject.Find("Platok");
        block.SetActive(true);
        Destroy(platok);
    }

    public void UsingPhone()
    {
        score += 1;
    }

    public void win()
    {
        audioSources[0].Stop();
        audioSources[1].Play();
        Text txt = winText.GetComponent<Text>();
        txt.text = "Ваш результат " + score.ToString();
        winText.SetActive(true);
        texter.SetActive(true);
    }

    private bool used = false;
    public void EnergeOff()
    {
        if (used = false)
        {
            score += 1;
            used = true;
        }
    }

    
}