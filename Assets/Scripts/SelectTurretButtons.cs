using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTurretButtons : MonoBehaviour
{
    public GameObject firstTurretUI;

    public GameObject secondTurretUI;
    public Button secondB;
    public Button secondBuyButton;
    public static bool secondButtonIsBuy = false;

    public GameObject threeTurretUI;
    public Button threeB;
    public Button threeBuyButton;
    public static bool threeButtonIsBuy = false;

    private void Start()
    {
        if (secondButtonIsBuy == true)
        {
            secondB.interactable = true;
            SpawnManager.spawnEmemyType = 2;
            secondBuyButton.gameObject.SetActive(false);
        }

        if (threeButtonIsBuy == true)
        {
            SpawnManager.spawnEmemyType = 3;
            threeB.interactable = true;
            threeBuyButton.gameObject.SetActive(false);
        }

        firstTurretUI.gameObject.SetActive(true);
        secondTurretUI.gameObject.SetActive(false);
        threeTurretUI.gameObject.SetActive(false);
    }

    public void ButtonSelectFirstTurret()
    {
        firstTurretUI.gameObject.SetActive(true);
        secondTurretUI.gameObject.SetActive(false);
        threeTurretUI.gameObject.SetActive(false);
    }
    public void ButtonSelectSecondTurret()
    {
        firstTurretUI.gameObject.SetActive(false);
        secondTurretUI.gameObject.SetActive(true);
        threeTurretUI.gameObject.SetActive(false);
    }
    public void ButtonSelectThreeTurret()
    {
        firstTurretUI.gameObject.SetActive(false);
        secondTurretUI.gameObject.SetActive(false);
        threeTurretUI.gameObject.SetActive(true);
    }

    public void BuySecondButton()
    {
        if (PlayerStats.money >= 2000)
        {
            secondB.interactable = true;
            SpawnManager.spawnEmemyType = 2;
            secondButtonIsBuy = true;
            secondBuyButton.gameObject.SetActive(false);
            PlayerStats.money -= 2000;
        }
    }

    public void BuyThreeButton()
    {
        if (PlayerStats.money >= 3000)
        {
            threeB.interactable = true;
            SpawnManager.spawnEmemyType = 3;
            threeButtonIsBuy = true;
            threeBuyButton.gameObject.SetActive(false);
            PlayerStats.money -= 2000;
        }
    }
}
