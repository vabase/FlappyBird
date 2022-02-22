using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void ReloadScene()
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(0);

    }

    public void LoadMainMenu()
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene(2);
        ResumeGame();

    }
    public void Exit() { Application.Quit(); }

    public void ResumeGame() { Time.timeScale = 1; }



}
