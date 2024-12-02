using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    int gameScore = 0;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject gameOverScreen;
    [ContextMenu("add point")]

    public void AddPoint(int pointsToAdd)
    {
        gameScore += pointsToAdd;
        scoreText.text = "score: " + gameScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}