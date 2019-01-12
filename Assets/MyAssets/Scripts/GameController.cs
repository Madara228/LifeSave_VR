using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float seconds;
    public Text timer_txt;
    void Start()
    {
        //StopCoroutine(Timer_of_end());
        Debug.Log("time");
    }

    private void Update()
    {
      // Debug.Log(seconds);
        seconds -= Time.deltaTime;
        timer_txt.text = Mathf.RoundToInt(seconds).ToString();
        if (seconds <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void windows()
    {
        Camera camera = Camera.main;
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            Destroy(hit.transform.gameObject);
            // Do something with the object that was hit by the raycast.
        }
    }

    
}
