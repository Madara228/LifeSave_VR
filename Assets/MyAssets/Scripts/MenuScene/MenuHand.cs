using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHand : MonoBehaviour
{
    public void Escape_from_fire()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Tutorial_scene_for_fire()
    {
        Debug.Log("tutor");
    }
}
