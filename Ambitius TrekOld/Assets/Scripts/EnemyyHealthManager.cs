using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyyHealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHeath;

    private PlayerStats thePlayerStats;

    public int expToGive;

    public string enemyQuestName;

    private QuestManager theQM;

    // Use this for initialization
    void Start()
    {
        CurrentHeath = MaxHealth;

        thePlayerStats = FindObjectOfType<PlayerStats>();
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHeath <= 0)
        {
            theQM.enemyKilled = enemyQuestName;
            Destroy(gameObject);

            thePlayerStats.AddExperience(expToGive);
       }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHeath -= damageToGive;
    }

    public void SetMaxHealth()
    {
        MaxHealth = CurrentHeath;
    }
}
