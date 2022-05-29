using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    static bool gameIsOpen = false;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        if (gameIsOpen == false)
        {
            LoadProgress();
            gameIsOpen = true;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable]
    class SaveData
    {
        public float playerMoney;
        public int playerDamage;
        public float playerSpeed;
        public float playerFireRate;
        public GameObject playerWeapon;

        ///

        public float s_UpgradePlayerDamageCost;
        public int s_UpgradePlayerDamageValue;
        public float s_damageCostMultiply;

        public float s_UpgradePlayerSpeedCost;
        public float s_UpgradePlayerSpeedValue;
        public float s_speedCostMultiply;

        public float s_UpgradePlayerCooldownCost;
        public float s_UpgradePlaterCooldownValue;
        public float s_CooldownCostMultiply;

        /// FIRST TURRET

        public int firstTurretDamage;
        public float firstTurretFireRate;
        public float firstTurretAttackDistance;

        public float s_FirstTurretUpgradeDamageCost;
        public int s_FirstTurretUpgradeDamageValue;
        public float s_FirstTurretDamageCostMultiply;

        public float s_FirstTurretUpgradeCooldownCost;
        public float s_FirstTurretUpgradeCooldownValue;
        public float s_FirstTurretCooldownCostMultiply;

        public float s_FirstTurretUpgradeAttackDistanceCost;
        public float s_FirstTurretUpgradeAttackDistanceValue;
        public float s_FirstTurretUpgradeAttackDistanceMultiply;

        /// SECOND TURRET

        public bool secondTurretIsBuy;

        public int secondTurretDamage;
        public float secondTurretFireRate;
        public float secondTurretAttackDistance;

        public float s_SecondTurretUpgradeDamageCost;
        public int s_SecondTurretUpgradeDamageValue;
        public float s_SecondTurretDamageCostMultiply;

        public float s_SecondTurretUpgradeCooldownCost;
        public float s_SecondTurretUpgradeCooldownValue;
        public float s_SecondTurretCooldownCostMultiply;

        public float s_SecondTurretUpgradeAttackDistanceCost;
        public float s_SecondTurretUpgradeAttackDistanceValue;
        public float s_SecondTurretUpgradeAttackDistanceMultiply;

        ///THREE TURRET

        public bool threeTurretIsBuy;

        public int threeTurretDamage;
        public float threeTurretFireRate;
        public float threeTurretAttackDistance;

        public float s_ThreeTurretUpgradeDamageCost;
        public int s_ThreeTurretUpgradeDamageValue;
        public float s_ThreeTurretDamageCostMultiply;

        public float s_ThreeTurretUpgradeCooldownCost;
        public float s_ThreeTurretUpgradeCooldownValue;
        public float s_ThreeTurretCooldownCostMultiply;

        public float s_ThreeTurretUpgradeAttackDistanceCost;
        public float s_ThreeTurretUpgradeAttackDistanceValue;
        public float s_ThreeTurretUpgradeAttackDistanceMultiply;

        ///SHOP

        public bool s_pressedButton;
        public Vector2 s_lastPosition;

        ///
    }

    public void SaveProgres()
    {
        SaveData data = new SaveData();

        ///

        data.playerMoney = PlayerStats.money;
        data.playerDamage = PlayerStats.damage;
        data.playerSpeed = PlayerStats.speed;
        //data.playerFireRate = PlayerStats.fireRate;
        data.playerWeapon = PlayerController.playerWeapon;

        ///

    data.s_UpgradePlayerDamageCost = UpgradeManager.UpgradePlayerDamageCost;
        data.s_UpgradePlayerDamageValue = UpgradeManager.UpgradePlayerDamageValue;
        data.s_damageCostMultiply = UpgradeManager.damageCostMultiply;

        data.s_UpgradePlayerSpeedCost = UpgradeManager.UpgradePlayerSpeedCost;
        data.s_UpgradePlayerSpeedValue = UpgradeManager.UpgradePlayerSpeedValue;
        data.s_speedCostMultiply = UpgradeManager.speedCostMultiply;

        data.s_UpgradePlayerCooldownCost = UpgradeManager.UpgradePlayerCooldownCost;
        data.s_UpgradePlaterCooldownValue = UpgradeManager.UpgradePlayerCooldownValue;
        data.s_CooldownCostMultiply = UpgradeManager.CooldownCostMultiply;

        ///FIRST TURRET

        data.firstTurretDamage = FirstTurrett.turretDamage;
        data.firstTurretFireRate = FirstTurrett.fireRate;
        data.firstTurretAttackDistance = FirstTurrett.attackDistance;

        data.s_FirstTurretUpgradeDamageCost = UpgradeManager.FirstTurretUpgradeDamageCost;
        data.s_FirstTurretUpgradeDamageValue = UpgradeManager.FirstTurretUpgradeDamageValue;
        data.s_FirstTurretDamageCostMultiply = UpgradeManager.FirstTurretDamageCostMultiply;

        data.s_FirstTurretUpgradeCooldownCost = UpgradeManager.FirstTurretUpgradeCooldownCost;
        data.s_FirstTurretUpgradeCooldownValue = UpgradeManager.FirstTurretUpgradeCooldownValue;
        data.s_FirstTurretCooldownCostMultiply = UpgradeManager.FirstTurretUpgradeCooldownCostMultiply;

        data.s_FirstTurretUpgradeAttackDistanceCost = UpgradeManager.FirstTurretUpgradeAttackDistanceCost;
        data.s_FirstTurretUpgradeAttackDistanceValue = UpgradeManager.FirstTurretUpgradeAttackDistanceValue;
        data.s_FirstTurretUpgradeAttackDistanceMultiply = UpgradeManager.FirstTurretUpgradeAttackDistanceCostMultiply;

        ///SECOND TUREET

        data.secondTurretIsBuy = SelectTurretButtons.secondButtonIsBuy;

        data.secondTurretDamage = SecondTurret.turretDamage;
        data.secondTurretFireRate = SecondTurret.fireRate;
        data.secondTurretAttackDistance = SecondTurret.attackDistance;

        data.s_SecondTurretUpgradeDamageCost = UpgradeManager.SecondTurretUpgradeDamageCost;
        data.s_SecondTurretUpgradeDamageValue = UpgradeManager.SecondTurretUpgradeDamageValue;
        data.s_SecondTurretDamageCostMultiply = UpgradeManager.SecondTurretUpgradeDamageCostMultiply;

        data.s_SecondTurretUpgradeCooldownCost = UpgradeManager.SecondTurretUpgradeCooldownCost;
        data.s_SecondTurretUpgradeCooldownValue = UpgradeManager.SecondTurretUpgradeCooldownValue;
        data.s_SecondTurretCooldownCostMultiply = UpgradeManager.SecondTurretUpgradeCooldownCostMultiply;

        data.s_SecondTurretUpgradeAttackDistanceCost = UpgradeManager.SecondTurretUpgradeAttackDistanceCost;
        data.s_SecondTurretUpgradeAttackDistanceValue = UpgradeManager.SecondTurretUpgradeAttackDistanceValue;
        data.s_SecondTurretUpgradeAttackDistanceMultiply = UpgradeManager.SecondTurretUpgradeAttackDistanceMultiply;

        ///THREE TURRET

        data.threeTurretIsBuy = SelectTurretButtons.threeButtonIsBuy;

        data.threeTurretDamage = ThreeTurret.turretDamage;
        data.threeTurretFireRate = ThreeTurret.fireRate;
        data.threeTurretAttackDistance = ThreeTurret.attackDistance;

        data.s_ThreeTurretUpgradeDamageCost = UpgradeManager.ThreeTurretUpgradeDamageCost;
        data.s_ThreeTurretUpgradeDamageValue = UpgradeManager.ThreeTurretUpgradeDamageValue;
        data.s_ThreeTurretDamageCostMultiply = UpgradeManager.ThreeTurretUpgradeDamageCostMultiply;

        data.s_ThreeTurretUpgradeCooldownCost = UpgradeManager.ThreeTurretUpgradeCooldownCost;
        data.s_ThreeTurretUpgradeCooldownValue = UpgradeManager.ThreeTurretUpgradeCooldownValue;
        data.s_ThreeTurretCooldownCostMultiply = UpgradeManager.ThreeTurretUpgradeCooldownCostMultiply;

        data.s_ThreeTurretUpgradeAttackDistanceCost = UpgradeManager.ThreeTurretUpgradeAttackDistanceCost;
        data.s_ThreeTurretUpgradeAttackDistanceValue = UpgradeManager.ThreeTurretUpgradeAttackDistanceValue;
        data.s_ThreeTurretUpgradeAttackDistanceMultiply = UpgradeManager.ThreeTurretUpgradeAttackDistanceMultiply;

        ///SHOP

        data.s_pressedButton = SelectWeaponButton.pressedButton;
        data.s_lastPosition = SelectWeaponButton.lastPosition;

    ///
    string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/cuberzombysave.json", json);

        Debug.Log("Progress is saved");
    }

    public void LoadProgress()
    {
        string path = Application.persistentDataPath + "/cuberzombysave.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            ///

            PlayerStats.money = data.playerMoney;
            PlayerStats.damage = data.playerDamage;
            PlayerStats.speed = data.playerSpeed;
            //PlayerStats.fireRate = data.playerFireRate;
            PlayerController.playerWeapon = data.playerWeapon;

            ///

            UpgradeManager.UpgradePlayerDamageCost = data.s_UpgradePlayerDamageCost;
            UpgradeManager.UpgradePlayerDamageValue = data.s_UpgradePlayerDamageValue;
            UpgradeManager.damageCostMultiply = data.s_damageCostMultiply;

            UpgradeManager.UpgradePlayerSpeedCost = data.s_UpgradePlayerSpeedCost;
            UpgradeManager.UpgradePlayerSpeedValue = data.s_UpgradePlayerSpeedValue;
            UpgradeManager.speedCostMultiply = data.s_speedCostMultiply;

            UpgradeManager.UpgradePlayerCooldownCost = data.s_UpgradePlayerCooldownCost;
            UpgradeManager.UpgradePlayerCooldownValue = data.s_UpgradePlaterCooldownValue;
            UpgradeManager.CooldownCostMultiply = data.s_CooldownCostMultiply;

            ///FIRST TURRET

            FirstTurrett.fireRate = data.firstTurretFireRate;
            FirstTurrett.attackDistance = data.firstTurretAttackDistance;
            FirstTurrett.turretDamage = data.firstTurretDamage;

            UpgradeManager.FirstTurretUpgradeDamageCost = data.s_FirstTurretUpgradeDamageCost;
            UpgradeManager.FirstTurretUpgradeDamageValue = data.s_FirstTurretUpgradeDamageValue;
            UpgradeManager.FirstTurretDamageCostMultiply = data.s_FirstTurretDamageCostMultiply;

            UpgradeManager.FirstTurretUpgradeCooldownCost = data.s_FirstTurretUpgradeCooldownCost;
            UpgradeManager.FirstTurretUpgradeCooldownValue = data.s_FirstTurretUpgradeCooldownValue;
            UpgradeManager.FirstTurretUpgradeCooldownCostMultiply = data.s_FirstTurretCooldownCostMultiply;

            UpgradeManager.FirstTurretUpgradeAttackDistanceCost = data.s_FirstTurretUpgradeAttackDistanceCost;
            UpgradeManager.FirstTurretUpgradeAttackDistanceValue = data.s_FirstTurretUpgradeAttackDistanceValue;
            UpgradeManager.FirstTurretUpgradeAttackDistanceCostMultiply = data.s_FirstTurretUpgradeAttackDistanceMultiply;

            ///SECOND TURRET

            SelectTurretButtons.secondButtonIsBuy = data.secondTurretIsBuy;

            SecondTurret.turretDamage = data.secondTurretDamage;
            SecondTurret.fireRate = data.secondTurretFireRate;
            SecondTurret.attackDistance = data.secondTurretAttackDistance;

            UpgradeManager.SecondTurretUpgradeDamageCost = data.s_SecondTurretUpgradeDamageCost;
            UpgradeManager.SecondTurretUpgradeDamageValue = data.s_SecondTurretUpgradeDamageValue;
            UpgradeManager.SecondTurretUpgradeDamageCostMultiply = data.s_SecondTurretDamageCostMultiply;

            UpgradeManager.SecondTurretUpgradeCooldownCost = data.s_SecondTurretUpgradeCooldownCost;
            UpgradeManager.SecondTurretUpgradeCooldownValue = data.s_SecondTurretUpgradeCooldownValue;
            UpgradeManager.SecondTurretUpgradeCooldownCostMultiply = data.s_SecondTurretCooldownCostMultiply;

            UpgradeManager.SecondTurretUpgradeAttackDistanceCost = data.s_SecondTurretUpgradeAttackDistanceCost;
            UpgradeManager.SecondTurretUpgradeAttackDistanceValue = data.s_SecondTurretUpgradeAttackDistanceValue;
            UpgradeManager.SecondTurretUpgradeAttackDistanceMultiply = data.s_SecondTurretUpgradeAttackDistanceMultiply;

            ///THREE TURRET

            SelectTurretButtons.threeButtonIsBuy = data.threeTurretIsBuy ;

            ThreeTurret.turretDamage = data.threeTurretDamage;
            ThreeTurret.fireRate = data.threeTurretFireRate;
            ThreeTurret.attackDistance = data.threeTurretAttackDistance;

            UpgradeManager.ThreeTurretUpgradeDamageCost = data.s_ThreeTurretUpgradeDamageCost;
            UpgradeManager.ThreeTurretUpgradeDamageValue = data.s_ThreeTurretUpgradeDamageValue;
            UpgradeManager.ThreeTurretUpgradeDamageCostMultiply = data.s_ThreeTurretDamageCostMultiply;

            UpgradeManager.ThreeTurretUpgradeCooldownCost = data.s_ThreeTurretUpgradeCooldownCost;
            UpgradeManager.ThreeTurretUpgradeCooldownValue = data.s_ThreeTurretUpgradeCooldownValue;
            UpgradeManager.ThreeTurretUpgradeCooldownCostMultiply = data.s_ThreeTurretCooldownCostMultiply;

            UpgradeManager.ThreeTurretUpgradeAttackDistanceCost = data.s_ThreeTurretUpgradeAttackDistanceCost;
            UpgradeManager.ThreeTurretUpgradeAttackDistanceValue = data.s_ThreeTurretUpgradeAttackDistanceValue ;
            UpgradeManager.ThreeTurretUpgradeAttackDistanceMultiply = data.s_ThreeTurretUpgradeAttackDistanceMultiply;

            ///SHOP

            SelectWeaponButton.pressedButton = data.s_pressedButton;
            SelectWeaponButton.lastPosition = data.s_lastPosition;

            ///
        }
        Debug.Log("Progress is load");
    }
}