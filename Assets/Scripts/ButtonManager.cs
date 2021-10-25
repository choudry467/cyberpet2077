using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadScene(string GameScene)
    {
        SceneManager.LoadScene(GameScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}