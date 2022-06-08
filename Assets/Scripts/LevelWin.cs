using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelWin : MonoBehaviour
{
    public AudioClip click;
    public GameObject levelWinUI;

    public SceneFader sceneFader;

    public bool levelWin = false;

    public int nextLevelInt;

    public void LevelComplete()
    {
        levelWinUI.SetActive(true);
        PlayerPrefs.SetInt("LevelReached", nextLevelInt);
        levelWin = true;
    }

    public void Menu()
    {
        PlayerController.playerAudio.PlayOneShot(click);
        Time.timeScale = 1f;
        sceneFader.FadeTo("MainMenu");
    }

    public void NextLevel(string levelName)
    {
        PlayerController.playerAudio.PlayOneShot(click);
        sceneFader.FadeTo(levelName);
    }
}
