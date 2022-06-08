using UnityEngine.UI;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public SceneFader sceneFader;

    public Text playerDamageText;
    public Text playerSpeedText;
    public Text playerCooldownText;
    public Text playerMoneyText;


    public static float UpgradePlayerDamageCost = 100;
      public static int UpgradePlayerDamageValue = 10;
    public static float damageCostMultiply = 1.2f;

    public static float UpgradePlayerSpeedCost = 200;
    public static float UpgradePlayerSpeedValue = 1;
    public static float speedCostMultiply = 1.2f;

    public static float UpgradePlayerCooldownCost = 300;
    public static float UpgradePlayerCooldownValue = 0.1f;
    public static float CooldownCostMultiply = 1.2f;

    ///FIRST TURRET

    public Text firstTurretDamageText;
    public Text firstTurretCooldownText;
    public Text firstTurretAttackDistanceText;

    public static float FirstTurretUpgradeDamageCost = 500;
      public static int FirstTurretUpgradeDamageValue = 10;
    public static float FirstTurretDamageCostMultiply = 1.2f;

    public static float FirstTurretUpgradeCooldownCost = 600;
    public static float FirstTurretUpgradeCooldownValue = 0.1f;
    public static float FirstTurretUpgradeCooldownCostMultiply = 1.2f;

    public static float FirstTurretUpgradeAttackDistanceCost = 700;
    public static float FirstTurretUpgradeAttackDistanceValue = 1;
    public static float FirstTurretUpgradeAttackDistanceCostMultiply = 1.2f;

    ///SECOND TURRET

    public Text secondTurretDamageText;
    public Text secondTurretCooldownText;
    public Text secondTurretAttackDistanceText;

    public static float SecondTurretUpgradeDamageCost = 1000;
    public static int SecondTurretUpgradeDamageValue = 10;
    public static float SecondTurretUpgradeDamageCostMultiply = 1.2f;

    public static float SecondTurretUpgradeCooldownCost = 1500;
    public static float SecondTurretUpgradeCooldownValue = 0.1f;
    public static float SecondTurretUpgradeCooldownCostMultiply = 1.2f;

    public static float SecondTurretUpgradeAttackDistanceCost = 2000;
    public static float SecondTurretUpgradeAttackDistanceValue = 1;
    public static float SecondTurretUpgradeAttackDistanceMultiply = 1.2f;

    ///THREE TURRET

    public Text threeTurretDamageText;
    public Text threeTurretCooldownText;
    public Text threeTurretAttackDistanceText;

    public static float ThreeTurretUpgradeDamageCost = 2500;
    public static int ThreeTurretUpgradeDamageValue = 10;
    public static float ThreeTurretUpgradeDamageCostMultiply = 1.2f;

    public static float ThreeTurretUpgradeCooldownCost = 3000;
    public static float ThreeTurretUpgradeCooldownValue = 0.1f;
    public static float ThreeTurretUpgradeCooldownCostMultiply = 1.2f;

    public static float ThreeTurretUpgradeAttackDistanceCost = 3500;
    public static float ThreeTurretUpgradeAttackDistanceValue = 1;
    public static float ThreeTurretUpgradeAttackDistanceMultiply = 1.2f;

    ///


    private void Update()
    {
        playerDamageText.text = "DAMAGE: " + PlayerStats.damage;
        playerSpeedText.text = "SPEED: " + PlayerStats.speed;
        //playerCooldownText.text = "COOLDOWN: " + string.Format("{0:0.0}", PlayerStats.fireRate);
        playerMoneyText.text = "$" + string.Format("{0:00}", PlayerStats.money);

        ///FIRST TURRET

        firstTurretDamageText.text = "DAMAGE: " + FirstTurrett.turretDamage;
        firstTurretCooldownText.text = "COOLDOWN: " + string.Format("{0:0.0}", FirstTurrett.fireRate); 
        firstTurretAttackDistanceText.text = "ATTACK DISTANCE: " + FirstTurrett.attackDistance;

        ///SECOND TURRET

        secondTurretDamageText.text = "DAMAGE: " + SecondTurret.turretDamage;
        secondTurretCooldownText.text = "COOLDOWN: " + string.Format("{0:0.0}", SecondTurret.fireRate);
        secondTurretAttackDistanceText.text = "ATTACK DISTANCE: " + SecondTurret.attackDistance;

        ///THREE TURRET

        threeTurretDamageText.text = "DAMAGE: " + ThreeTurret.turretDamage;
        threeTurretCooldownText.text = "COOLDOWN: " + string.Format("{0:0.0}", ThreeTurret.fireRate);
        threeTurretAttackDistanceText.text = "ATTACK DISTANCE: " + ThreeTurret.attackDistance;

        ///

    }

    public void Menu()
    {
        sceneFader.FadeTo("MainMenu");
        SaveManager.instance.SaveProgres();
    }

    public void Shop()
    {
        sceneFader.FadeTo("ShopScene");
        SaveManager.instance.SaveProgres();
    }

    public void UpgradePlayerDamage()
    {
        if (PlayerStats.money >= UpgradePlayerDamageCost)
        {
            PlayerStats.damage += UpgradePlayerDamageValue;
            PlayerStats.money -= UpgradePlayerDamageCost;

            UpgradePlayerDamageValue++;
            UpgradePlayerDamageCost *= damageCostMultiply;
            //if (damageCostMultiply < 1.8f)
            //{
            //    damageCostMultiply += 0.1f;
            //}
        }
    }

    public void UpgradePlayerSpeed()
    {
        if (PlayerStats.money >= UpgradePlayerSpeedCost)
        {
            PlayerStats.speed += UpgradePlayerSpeedValue;
            UpgradePlayerSpeedValue++;
            PlayerStats.money -= UpgradePlayerSpeedCost;

            UpgradePlayerSpeedCost *= speedCostMultiply;
            //if (speedCostMultiply < 1.8f)
            //{
            //    speedCostMultiply += 0.1f;
            //}
        }
    }

    public void UpgradePlayerCooldown()
    {
        if (PlayerStats.money >= UpgradePlayerCooldownCost)
        {
            //PlayerStats.fireRate += UpgradePlayerCooldownValue;
            PlayerStats.money -= UpgradePlayerCooldownCost;
            UpgradePlayerCooldownCost *= CooldownCostMultiply;
            //if (CooldownCostMultiply < 1.8f)
            //{
            //    CooldownCostMultiply += 0.1f;
            //}
        }
    }

    ///FIRST TURRET

    public void UpgradeFirstTurretDamage()
    {
        if (PlayerStats.money >= FirstTurretUpgradeDamageCost)
        {
            FirstTurrett.turretDamage += FirstTurretUpgradeDamageValue;
            FirstTurretUpgradeDamageValue++;
            PlayerStats.money -= FirstTurretUpgradeDamageCost;
            FirstTurretUpgradeDamageCost *= FirstTurretDamageCostMultiply;
            //if (FirstTurretDamageCostMultiply < 1.8f)
            //{
            //    FirstTurretDamageCostMultiply += 0.1f;
            //}

        }
    }

    public void UpgradeFirstTurretCooldown()
    {
        if (PlayerStats.money >= FirstTurretUpgradeCooldownCost)
        {
            FirstTurrett.fireRate += FirstTurretUpgradeCooldownValue;
            //FirstTurretUpgradeCooldownValue += 0.1f;
            PlayerStats.money -= FirstTurretUpgradeCooldownCost;
            FirstTurretUpgradeCooldownCost *= FirstTurretUpgradeCooldownCostMultiply;
            //if (FirstTurretUpgradeCooldownCostMultiply < 1.8f)
            //{
            //    FirstTurretUpgradeCooldownCostMultiply += 0.1f;
            //}

        }
    }

    public void UpgradeFirstTurretAttackDistance()
    {
        if (PlayerStats.money >= FirstTurretUpgradeAttackDistanceCost)
        {
            FirstTurrett.attackDistance += FirstTurretUpgradeAttackDistanceValue;
            FirstTurretUpgradeAttackDistanceValue++;
            PlayerStats.money -= FirstTurretUpgradeAttackDistanceCost;
            FirstTurretUpgradeAttackDistanceCost *= FirstTurretUpgradeAttackDistanceCostMultiply;
            //if (FirstTurretUpgradeAttackDistanceCostMultiply < 1.8f)
            //{
            //    FirstTurretUpgradeAttackDistanceCostMultiply += 0.1f;
            //}

        }
    }

    /// SECOND TURRET
    
    public void UpgradeSecondTurretDamage()
    {
        if (PlayerStats.money >= SecondTurretUpgradeDamageCost)
        {
            SecondTurret.turretDamage += SecondTurretUpgradeDamageValue;
            SecondTurretUpgradeDamageValue++;
            PlayerStats.money -= SecondTurretUpgradeDamageCost;
            SecondTurretUpgradeDamageCost *= SecondTurretUpgradeDamageCostMultiply;
            //if (SecondTurretUpgradeDamageCostMultiply < 1.8f)
            //{
            //    SecondTurretUpgradeDamageCostMultiply += 0.1f;
            //}
        }
    }

    public void UpgradeSecondTurretCoolDown()
    {
        if (PlayerStats.money >= SecondTurretUpgradeCooldownCost)
        {
            SecondTurret.fireRate += SecondTurretUpgradeCooldownValue;
            PlayerStats.money -= SecondTurretUpgradeCooldownCost;
            SecondTurretUpgradeCooldownCost *= SecondTurretUpgradeCooldownCostMultiply;
            //if (SecondTurretUpgradeCooldownCostMultiply < 1.8)
            //{
            //    SecondTurretUpgradeCooldownCostMultiply += 0.1f;
            //}

        }
    }

    public void UpgradeSecondTurretAttackDistance()
    {
        if (PlayerStats.money >= SecondTurretUpgradeAttackDistanceCost)
        {
            SecondTurret.attackDistance += SecondTurretUpgradeAttackDistanceValue;
            SecondTurretUpgradeAttackDistanceValue++;
            PlayerStats.money -= SecondTurretUpgradeAttackDistanceCost;
            SecondTurretUpgradeAttackDistanceCost *= SecondTurretUpgradeAttackDistanceMultiply;
            //if (SecondTurretUpgradeAttackDistanceMultiply < 1.8)
            //{
            //    SecondTurretUpgradeAttackDistanceMultiply += 0.1f;
            //}
        }
    }

    ///THREE TURRET

    public void UpgradeThreeTurretDamage()
    {
        if (PlayerStats.money >= ThreeTurretUpgradeDamageCost)
        {
            ThreeTurret.turretDamage += ThreeTurretUpgradeDamageValue;
            ThreeTurretUpgradeDamageValue++;
            PlayerStats.money -= ThreeTurretUpgradeDamageCost;
            ThreeTurretUpgradeDamageCost *= ThreeTurretUpgradeDamageCostMultiply;
            //if (ThreeTurretUpgradeDamageCostMultiply < 1.8f)
            //{
            //    ThreeTurretUpgradeDamageCostMultiply += 0.1f;
            //}
        }
    }

    public void UpgradeThreeTurretCoolDown()
    {
        if (PlayerStats.money >= ThreeTurretUpgradeCooldownCost)
        {
            ThreeTurret.fireRate += ThreeTurretUpgradeCooldownValue;
            PlayerStats.money -= ThreeTurretUpgradeCooldownCost;
            ThreeTurretUpgradeCooldownCost *= ThreeTurretUpgradeCooldownCostMultiply;
            //if (ThreeTurretUpgradeCooldownCostMultiply < 1.8)
            //{
            //    ThreeTurretUpgradeCooldownCostMultiply += 0.1f;
            //}

        }
    }

    public void UpgradeThreeTurretAttackDistance()
    {
        if (PlayerStats.money >= ThreeTurretUpgradeAttackDistanceCost)
        {
            ThreeTurret.attackDistance += ThreeTurretUpgradeAttackDistanceValue;
            ThreeTurretUpgradeAttackDistanceValue++;
            PlayerStats.money -= ThreeTurretUpgradeAttackDistanceCost;
            ThreeTurretUpgradeAttackDistanceCost *= ThreeTurretUpgradeAttackDistanceMultiply;
            //if (ThreeTurretUpgradeAttackDistanceMultiply < 1.8)
            //{
            //    ThreeTurretUpgradeAttackDistanceMultiply += 0.1f;
            //}
        }
    }

    ///
}
