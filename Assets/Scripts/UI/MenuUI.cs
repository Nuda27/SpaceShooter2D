using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public InputHandler inputHandler;
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.GetInstance().OnGameOverAction += gameOver;
    }

    public void startGame()
    {
        mainMenu.SetActive(false);
    }

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        GameManager.GetInstance().pauseGame();
    }

    private void OnEnable()
    {
        inputHandler.OnPauseAction += pauseGame;
    }

    private void OnDisable()
    {
        inputHandler.OnPauseAction -= pauseGame;
    }

    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        GameManager.GetInstance().resumeGame();
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverMenu.SetActive(true);
    }

    public void retry()
    {
        gameOverMenu.SetActive(false);
        mainMenu.SetActive(true);
        GameManager.GetInstance().retry();
    }
}
