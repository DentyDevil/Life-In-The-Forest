using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyWeaponScript : MonoBehaviour
{
    public AudioClip click;

    public int secondWeaponCost;
    public Button secondB;
    public GameObject buySecondB;
    public Text buySecondText;
    public static bool secondWeaponIsBuy = false;

    public int threeWeaponCost;
    public Button threeB;
    public GameObject buyThreeB;
    public Text buyThreeText;
    public static bool threeWeaponIsBuy = false;

    public int fourthWeaponCost;
    public Button fourthB;
    public GameObject buyFourthB;
    public Text buyFourthText;
    public static bool fourthWeaponIsBuy = false;

    private void Start()
    {
        buySecondText.text = "BUY $" + secondWeaponCost;
        buyThreeText.text = "BUY $" + threeWeaponCost;
        buyFourthText.text = "BUY $" + fourthWeaponCost;

        if (secondWeaponIsBuy == true)
        {
            secondB.interactable = true;
            buySecondB.SetActive(false);
        }
        if (threeWeaponIsBuy == true)
        {
            threeB.interactable = true;
            buyThreeB.SetActive(false);
        }
        if (fourthWeaponIsBuy == true)
        {
            fourthB.interactable = true;
            buyFourthB.SetActive(false);
        }
    }

    public void BuySecondWeapon()
    {
        UpgradeManager.audioSource.PlayOneShot(click);
        if (PlayerStats.money >= secondWeaponCost)
        {
            secondB.interactable = true;
            buySecondB.SetActive(false);
            PlayerStats.money -= secondWeaponCost;
            secondWeaponIsBuy = true;
        }
    }
    public void BuyThreeWeapon()
    {
        UpgradeManager.audioSource.PlayOneShot(click);
        if (PlayerStats.money >= threeWeaponCost)
        {
            threeB.interactable = true;
            buyThreeB.SetActive(false);
            PlayerStats.money -= threeWeaponCost;
            threeWeaponIsBuy = true;
        }
    }
    public void BuyFourthWeapon()
    {
        UpgradeManager.audioSource.PlayOneShot(click);
        if (PlayerStats.money >= fourthWeaponCost)
        {
            fourthB.interactable = true;
            buyFourthB.SetActive(false);
            PlayerStats.money -= fourthWeaponCost;
            fourthWeaponIsBuy = true;
        }
    }
}
