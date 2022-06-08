using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeaponButton : MonoBehaviour
{
    public GameObject textSelect;
    public static bool pressedButton = false;
    public static Vector2 lastPosition;
    private void Start()
    {
        if (pressedButton == true)
        {
            textSelect.transform.position = lastPosition;
            textSelect.SetActive(true);
        }
    }
    public void SelectedWeapon(GameObject WeaponPrefab)
    {
        PlayerController.playerWeapon = WeaponPrefab;
        pressedButton = true;
        textSelect.SetActive(true);
        textSelect.transform.position = new Vector2(transform.position.x, transform.position.y - 30);
        lastPosition = new Vector2(textSelect.transform.position.x, textSelect.transform.position.y);
    }

    public void Menu()
    {
        SaveManager.instance.SaveProgres();
        SceneFader fader = GameObject.Find("SceneFader").GetComponent<SceneFader>();
        fader.FadeTo("MainMenu");
    }
}
