using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public SceneFader sceneFader;

    public Button upgradeButton;

    public AudioSource source;
    public AudioClip click;

    private void Start()
    {
    }

    public void StatrButton()
    {
        sceneFader.FadeTo("MainScene");
        source.PlayOneShot(click);
        Time.timeScale = 1;
    }

    public void SelectLevelButton()
    {
        sceneFader.FadeTo("SelectLevel");
        source.PlayOneShot(click);
    }

    public void UpgradeScene()
    {
        sceneFader.FadeTo("UpgradeScene");
        source.PlayOneShot(click);
    }

    public void exitButton()
    {
        source.PlayOneShot(click);
        SaveManager.instance.SaveProgres();
        Application.Quit();
    }

    public void ResetProgress()
    {
        source.PlayOneShot(click);
        PlayerPrefs.SetInt("LevelReached", 1);
    }
}
