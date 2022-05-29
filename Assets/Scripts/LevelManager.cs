using UnityEngine.UI;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    [Header("One Turret")]
    public bool oneTurretActive = true;
    public float standardEnemiesKilled;
    public GameObject turretPrefab;
    public GameObject spawnPoint;
    public Text enemyStandardKillText;
    public Image enemyStandardBar;
    bool oneTurretBuild = false;
    public GameObject oneEnemyBar;


    [Header("Second Turret")]
    public bool secondTurretActive = true;
    public float fastEnemyKilled;
    public GameObject secondTurretPrefab;
    public GameObject secondSpawnPoint;
    public Text enemyFastKillText;
    public Image enemyFastBar;
    bool secondTurretBuild = false;
    public GameObject secondEnemyBar;


    [Header("Three Turret")]
    public bool ThreeTurretActive = true;
    public float slowEnemyKilled;
    public GameObject threeTurretPrefab;
    public GameObject threeSpawnPoint;
    public Text enemySlowKillText;
    public Image enemySlowBar;
    bool threeTurretbuild = false;
    public GameObject threeEnemyBar;


    [Header("Level Settings")]
    public int enemyKillCount = 0;

    public PlayerStats playerStats;

    [HideInInspector]
    public float killStandardEmemy;
    [HideInInspector]
    public float killFastEnemy;
    [HideInInspector]
    public float killSlowEnemy;
    [HideInInspector]
    LevelWin levelWin;

    private void Start()
    {
        levelWin = GetComponent<LevelWin>();
    }



    private void Update()
    {
        if (oneTurretActive == true)
        {
            killStandardEmemy = Mathf.Clamp(killStandardEmemy, 0, standardEnemiesKilled);
            enemyStandardKillText.text = killStandardEmemy + "/" + standardEnemiesKilled;
            enemyStandardBar.fillAmount = killStandardEmemy / standardEnemiesKilled;

            if (standardEnemiesKilled == killStandardEmemy && oneTurretBuild == false)
            {
                Instantiate(turretPrefab, spawnPoint.transform.position, turretPrefab.transform.rotation);
                oneTurretBuild = true;
            }
        }
        else
        {
            oneEnemyBar.gameObject.SetActive(false);
        }

        if (SelectTurretButtons.secondButtonIsBuy == true)
        {
            killFastEnemy = Mathf.Clamp(killFastEnemy, 0, fastEnemyKilled);
            enemyFastKillText.text = killFastEnemy + "/" + fastEnemyKilled;
            enemyFastBar.fillAmount = killFastEnemy / fastEnemyKilled;

            if (fastEnemyKilled == killFastEnemy && secondTurretBuild == false)
            {
                Instantiate(secondTurretPrefab, secondSpawnPoint.transform.position, secondTurretPrefab.transform.rotation);
                secondTurretBuild = true;
            }
        }
        else
        {
            secondEnemyBar.gameObject.SetActive(false);
        }

        if (SelectTurretButtons.threeButtonIsBuy == true)
        {
            killSlowEnemy = Mathf.Clamp(killSlowEnemy, 0, slowEnemyKilled);
            enemySlowKillText.text = killSlowEnemy + "/" + slowEnemyKilled;
            enemySlowBar.fillAmount = killSlowEnemy / slowEnemyKilled;

            if (slowEnemyKilled == killSlowEnemy && threeTurretbuild == false)
            {
                Instantiate(threeTurretPrefab, threeSpawnPoint.transform.position, threeSpawnPoint.transform.rotation);
                threeTurretbuild = true;
            }
        }
        else
        {
            threeEnemyBar.gameObject.SetActive(false);
        }

        if (playerStats.enemyKill == enemyKillCount)
        {
            levelWin.LevelComplete();
        }
    }

}
