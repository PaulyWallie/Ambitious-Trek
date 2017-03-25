using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExit : MonoBehaviour {

    public GameObject[] houseParts;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            for (int i = 0; i < houseParts.Length; i++)
            {
                houseParts[i].SetActive(false);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            for (int i = 0; i < houseParts.Length; i++)
            {
                houseParts[i].SetActive(true);
            }
        }
    }
}
