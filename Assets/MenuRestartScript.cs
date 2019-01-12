using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRestartScript : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
