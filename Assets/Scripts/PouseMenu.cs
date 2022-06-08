using UnityEngine.SceneManagement;
using UnityEngine;

public class PouseMenu : MonoBehaviour
{
    public AudioClip click;

    public GameObject ui;
    public SceneFader sceneFader;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Toggle();
        }
    }

    public void Toggle()
    {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void Retry()
    {
        PlayerController.playerAudio.PlayOneShot(click);
        Toggle();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        PlayerController.playerAudio.PlayOneShot(click);
        Time.timeScale = 1;
        sceneFader.FadeTo("MainMenu");
        SaveManager.instance.SaveProgres();
    }
}
