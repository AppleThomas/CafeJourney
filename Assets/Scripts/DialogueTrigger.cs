using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    [Header("Ink JSON")]
    //[SerializeField] private TextAsset inkJSON;
    [SerializeField] private TextAsset inkJSON1;
    [SerializeField] private TextAsset inkJSON2;
    [SerializeField] private TextAsset inkJSON3;
    [SerializeField] private TextAsset inkJSON4;
    [SerializeField] private TextAsset inkJSON5;


    private bool playerInRange;
    string npcName;

    private void Awake()
    {
        visualCue.SetActive(false);
        playerInRange = false;
    }

    private void Update()
    {
        if (playerInRange && !DialogueManager.GetInstance().dialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed())
            {
                //print("My name is  " + this.transform.parent.name);
                npcName = this.transform.parent.name;
                if (LevelManager.GetInstance().npcAffection[npcName] == 0)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON1);
                }
                else if (LevelManager.GetInstance().npcAffection[npcName] == 5)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON2);
                }
                else if (LevelManager.GetInstance().npcAffection[npcName] == 10)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON3);
                }
                else if (LevelManager.GetInstance().npcAffection[npcName] == 15)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON4);
                }
                else if (LevelManager.GetInstance().npcAffection[npcName] == 20)
                {
                    DialogueManager.GetInstance().EnterDialogueMode(inkJSON5);
                }
                else
                {
                    int currentAffection = LevelManager.GetInstance().npcAffection[npcName];
                    print("before is :" + currentAffection);
                    LevelManager.GetInstance().npcAffection[npcName] += 5 - (currentAffection % 5);
                    print("After is :" + LevelManager.GetInstance().npcAffection[npcName]);
                    print("You already talked to me fool");
                }
            }
        }
        else
        {
            visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
