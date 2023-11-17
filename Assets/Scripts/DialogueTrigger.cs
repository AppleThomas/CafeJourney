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
    [SerializeField] private TextAsset GenericDialogue;


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
                npcName = this.transform.parent.name;
                DialogueManager.GetInstance().npcName = this.transform.parent.name;

                // only do this for actual characters
                if (npcName != "GenericNPC" && LevelManager.GetInstance().npcFinished[npcName] == false)
                {
                    DialogueManager.GetInstance().isGeneric = false;
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
                        LevelManager.GetInstance().npcFinished[npcName] = true;
                    }
                    else
                    {
                        // if not enough affection, give 2 to boost them up a little.
                        int currentAffection = LevelManager.GetInstance().npcAffection[npcName];
                        
                        LevelManager.GetInstance().npcAffection[npcName] += 2;
                        DialogueManager.GetInstance().isGeneric = true;
                        DialogueManager.GetInstance().EnterDialogueMode(GenericDialogue);


                    }
                }
                else
                {
                    DialogueManager.GetInstance().npcName = this.transform.parent.name;
                    DialogueManager.GetInstance().isGeneric = true;
                    DialogueManager.GetInstance().EnterDialogueMode(GenericDialogue);
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
