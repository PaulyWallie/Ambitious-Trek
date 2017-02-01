using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour {

    public int QuestNumber;

    private QuestManager theQm;

    public string itemName;

	// Use this for initialization
	void Start () {
        theQm = FindObjectOfType<QuestManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if(!theQm.questCompleted[QuestNumber] && theQm.quests[QuestNumber].gameObject.activeSelf)
            {
                theQm.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }
    }
}
