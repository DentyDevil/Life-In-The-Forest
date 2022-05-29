using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //public bool gameIsOver = false;
    public GameObject gameOverText;
    private void Update()
    {
    }

    public void gameEnd()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
