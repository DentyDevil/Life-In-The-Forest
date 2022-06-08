using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    //public bool gameIsOver = false;
    public GameObject gameOverText;
    public AudioClip gameOverSound;
    public AudioClip click;

    private void Update()
    {
    }

    public void gameEnd()
    {
        gameOverText.SetActive(true);
        PlayerController.playerAudio.PlayOneShot(gameOverSound);
        Time.timeScale = 0;
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        PlayerController.playerAudio.PlayOneShot(click);
        Time.timeScale = 1;
    }
}
