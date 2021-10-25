using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("1");
    }

    public void Options()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
