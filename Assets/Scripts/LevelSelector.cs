using UnityEngine.UI;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip click;

    public SceneFader sceneFader;

    public Button[] levelButtons;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButtons[i].interactable = false;
        }
    }

    public void Select(string levelName)
    {
        audioSource.PlayOneShot(click);
        sceneFader.FadeTo(levelName);
    }

    public void Menu()
    {
        audioSource.PlayOneShot(click);
        sceneFader.FadeTo("MainMenu");
    }
}
