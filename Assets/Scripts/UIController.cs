using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Text playerHealthText;
    public Text waveDurationText;
    public Text enemyKillText;
    public Text playerMoneyText;

    PlayerStats playerStats;
    SpawnManager spawnManager;
    LevelManager levelManager;
    private void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<PlayerStats>();
        spawnManager = GetComponent<SpawnManager>();
        levelManager = GetComponent<LevelManager>();
    }

    private void Update()
    {
        playerStats.enemyKill = Mathf.Clamp(playerStats.enemyKill, 0, levelManager.enemyKillCount);

        playerHealthText.text = "HP: " + PlayerStats.Health + "/" + playerStats.startHealth;
        waveDurationText.text = "Wave Duration: " + string.Format("{0:00.00}", SpawnManager.waveDuration);
        enemyKillText.text = "Enemy kill: " + playerStats.enemyKill + "/" + levelManager.enemyKillCount;
        playerMoneyText.text = "$" + string.Format("{0:00}", PlayerStats.money);

    }
}
