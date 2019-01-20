using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public string dialogue;
    private DialogueManager dMan;

    public string[] DialogueLines;

    // Use this for initialization
    void Start() {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogActive)
                {
                    dMan.dialogLines = DialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialouge();
                }

                if (transform.parent.GetComponent<VillagerMovement>() != null)
                {
                    transform.parent.GetComponent<VillagerMovement>().canMove = false;
                }
            }
        }
    }
}