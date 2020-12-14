using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button startButton;
    public bool isGameActive;

    // Start the game
    public void StartGame()
    {
        isGameActive = true;
        titleScreen.SetActive(false);
    }

    // Ends game and brings up restart button
    public void GameOver()
    {
        if(!gameObject.CompareTag("Player"))
        {
          gameOverText.gameObject.SetActive(true);
          startButton.gameObject.SetActive(true);
          isGameActive = false;
        }
    }

    // Restarts the game
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
