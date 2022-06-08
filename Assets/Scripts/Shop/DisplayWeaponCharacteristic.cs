using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayWeaponCharacteristic : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    bool onmouse = false;
    Button button;

    public Text characteristicText;
    public GameObject panel;
    public FirstWeapon firstWeapon;
    public FirstBullet firstBullet;

    public SecondWeapon secondWeapon;
    public SecondBullet secondBullet;

    private void Update()
    {
        if (onmouse == true)
        {
            button = GetComponent<Button>();
            if (button.CompareTag("FirstWeapon"))
            {
                characteristicText.text = "DAMAGE: " + firstBullet.bulletDamage + "\nCOOLDOWN:" + firstWeapon.fireRate + "\nBULLET SPEED: " + firstBullet.bulletSpeed;
            }
            if (button.CompareTag("SecondWeapon"))
            {
                characteristicText.text = "DAMAGE: " + secondBullet.bulletDamage + "\nCOOLDOWN:" + secondWeapon.fireRate + "\nBULLET SPEED: " + secondBullet.bulletSpeed;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        characteristicText.gameObject.SetActive(true);
        panel.gameObject.SetActive(true);
        characteristicText.transform.position = new Vector2(transform.position.x, transform.position.y + 80);
        panel.transform.position = new Vector2(transform.position.x, transform.position.y + 80);

        onmouse = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        characteristicText.gameObject.SetActive(false);
        panel.gameObject.SetActive(false);
        onmouse = false;
    }
}
