using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownTrigger : MonoBehaviour {

    public GameObject weapon;

    PlayerController thePlayer;
   
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        thePlayer.canAttack = false;
        weapon.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        thePlayer.canAttack = true;
        weapon.SetActive(true);
    }

}
