using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    GameObject[] startGameUIComponets;
    GameObject[] gameOverUIComponets;
    [SerializeField] GameObject score;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        startGameUIComponets = GameObject.FindGameObjectsWithTag("StartGameUIComponets");
        gameOverUIComponets = GameObject.FindGameObjectsWithTag("gameOverUIComponets");
        DisableUICompent(gameOverUIComponets);
        EnableUIComponet(startGameUIComponets);
        DisableScore(score);


    }

    public void DisablestartUI()
    {
        DisableUICompent(startGameUIComponets);
    }

    public void GameOver()
    {
        EnableUIComponet(gameOverUIComponets);
        Time.timeScale = 0;
    }

    public void SnowScore()
    {
        score.SetActive(true);
    }

    private void EnableScore(GameObject score)
    {
        score.SetActive(true);
    }


    private void DisableScore(GameObject score)
    {
        score.SetActive(false);
    }

    private void EnableUIComponet(GameObject[] startGameUIComponets)
    {
        foreach (GameObject obj in startGameUIComponets)
        {
            obj.SetActive(true);
        }
    }

    private void DisableUICompent(GameObject[] gameOverUIComponets)
    {
        foreach (GameObject obj in gameOverUIComponets)
        {
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
