﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;

    public QuestManager theQM;

    public string startQuest;
    public string endQuest;

    public bool isItemQuest;
    public string targetItem;

    public bool isEnemyQuest;
    public string targetEnemy;
    public int enemiesToKill;
    private int enemyKillCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isItemQuest)
        {
            if (theQM.itemCollected == targetItem)
            {
                theQM.itemCollected = null;

                EndQuest();
            }
        }
        if (isEnemyQuest)
        {
            if (theQM.enemyKilled == targetEnemy)
            {
                theQM.enemyKilled = null;

                enemyKillCount++;
            }

            if (enemyKillCount >= enemiesToKill)
            {
                EndQuest();
            }
        }
	}

    public void StartQuest()
    {
        theQM.ShowQuestText(startQuest);
    }

    public void EndQuest()
    {
        theQM.ShowQuestText(endQuest);
        theQM.questCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
      
}
