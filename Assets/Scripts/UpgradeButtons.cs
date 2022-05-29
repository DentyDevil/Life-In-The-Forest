using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpgradeButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text text;
    Button button;
    bool onmouse = false;

    private void Update()
    {
        if (onmouse == true)
        {
            button = GetComponent<Button>();
            if (button.CompareTag("damage"))
            {
                text.text = "DAMAGE + " + UpgradeManager.UpgradePlayerDamageValue + "\n$" + string.Format("{0:00}", UpgradeManager.UpgradePlayerDamageCost); 
            }

            if (button.CompareTag("speed"))
            {
                text.text = "SPEED + " + UpgradeManager.UpgradePlayerSpeedValue + "\n$" + string.Format("{0:00}", UpgradeManager.UpgradePlayerSpeedCost);
            }
            if (button.CompareTag("FireRate"))
            {
                text.text = "FIRE RATE + " + UpgradeManager.UpgradePlayerCooldownValue + "\n$" + string.Format("{0:00}", UpgradeManager.UpgradePlayerCooldownCost);
            }

            ///FIRST TURRET

            if (button.CompareTag("TurretDamage"))
            {
                text.text = "DAMAGE + " + UpgradeManager.FirstTurretUpgradeDamageValue + "\n$" + string.Format("{0:00}", UpgradeManager.FirstTurretUpgradeDamageCost);
            }
            if (button.CompareTag("TurretCooldown"))
            {
                text.text = "COOLDOWN + " + UpgradeManager.FirstTurretUpgradeCooldownValue + "\n$" + string.Format("{0:00}", UpgradeManager.FirstTurretUpgradeCooldownCost);
            }
            if (button.CompareTag("TurretAttackDistance"))
            {
                text.text = "ATTACK DISTANCE + " + UpgradeManager.FirstTurretUpgradeAttackDistanceValue + "\n$" + string.Format("{0:00}", UpgradeManager.FirstTurretUpgradeAttackDistanceCost);
            }

            ///SECOND TURRET

            if (button.CompareTag("SecondTurretDamage"))
            {
                text.text = "DAMAGE + " + UpgradeManager.SecondTurretUpgradeDamageValue + "\n$" + string.Format("{0:00}", UpgradeManager.SecondTurretUpgradeDamageCost);
            }
            if (button.CompareTag("SecondTurretCooldown"))
            {
                text.text = "COOLDOWN + " + UpgradeManager.SecondTurretUpgradeCooldownValue + "\n$" + string.Format("{0:00}", UpgradeManager.SecondTurretUpgradeCooldownCost);
            }
            if (button.CompareTag("SecondTurretAttackDistance"))
            {
                text.text = "ATTACK DISTANCE + " + UpgradeManager.SecondTurretUpgradeAttackDistanceValue + "\n$" + string.Format("{0:00}", UpgradeManager.SecondTurretUpgradeAttackDistanceCost);
            }

            ///THREE TURRET

            if (button.CompareTag("ThreeTurretDamage"))
            {
                text.text = "DAMAGE + " + UpgradeManager.ThreeTurretUpgradeDamageValue + "\n$" + string.Format("{0:00}", UpgradeManager.ThreeTurretUpgradeDamageCost);
            }
            if (button.CompareTag("ThreeTurretCooldown"))
            {
                text.text = "COOLDOWN + " + UpgradeManager.ThreeTurretUpgradeCooldownValue + "\n$" + string.Format("{0:00}", UpgradeManager.ThreeTurretUpgradeCooldownCost);
            }
            if (button.CompareTag("ThreeTurretAttackDistance"))
            {
                text.text = "ATTACK DISTANCE + " + UpgradeManager.ThreeTurretUpgradeAttackDistanceValue + "\n$" + string.Format("{0:00}", UpgradeManager.ThreeTurretUpgradeAttackDistanceCost);
            }

            ///
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.gameObject.SetActive(true);
        text.transform.position = new Vector2(transform.position.x + 210, transform.position.y);

        onmouse = true;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.gameObject.SetActive(false);
        onmouse = false;
    }
}
