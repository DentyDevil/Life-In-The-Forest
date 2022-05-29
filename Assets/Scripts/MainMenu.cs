using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public SceneFader sceneFader;

    public Button upgradeButton;

    private void Start()
    {
    }

    public void StatrButton()
    {
        sceneFader.FadeTo("MainScene");
        Time.timeScale = 1;
    }

    public void SelectLevelButton()
    {
        sceneFader.FadeTo("SelectLevel");
    }

    public void UpgradeScene()
    {
        sceneFader.FadeTo("UpgradeScene");
    }

    public void exitButton()
    {
        SaveManager.instance.SaveProgres();
        Application.Quit();
    }

    public void ResetProgress()
    {
        PlayerPrefs.SetInt("LevelReached", 1);
    }
}
