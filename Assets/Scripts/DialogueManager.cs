using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class DialogueManager : MonoBehaviour
{

    [SerializeField] private GameObject GameUI;
    [SerializeField] private TextMeshProUGUI NameTag;


    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] choices;
    private TextMeshProUGUI[] choicesText;

    private Story currentStory;
    public bool dialogueIsPlaying { get; private set; }
    private static DialogueManager instance;

    public int currentAffection;
    public string npcName;
    public bool isGeneric;

    [Header("Character Portraits")]
    [SerializeField] private GameObject JenniePortrait;
    [SerializeField] private GameObject JessicaPortrait;
    [SerializeField] private GameObject EricPortrait;


    [Header("Affection Hearts")]
    [SerializeField] private GameObject Heart1;
    [SerializeField] private GameObject Heart2;
    [SerializeField] private GameObject Heart3;
    [SerializeField] private GameObject Heart4;
    [SerializeField] private GameObject Heart5;







    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Found more than one Dialogue Manager in the scene");
        }
        instance = this;
    }

    public void Start()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        JenniePortrait.SetActive(false);
        JessicaPortrait.SetActive(false);
        EricPortrait.SetActive(false);

        Heart1.SetActive(false);
        Heart2.SetActive(false);
        Heart3.SetActive(false);
        Heart4.SetActive(false);
        Heart5.SetActive(false);

        // get all of the choices text 
        choicesText = new TextMeshProUGUI[choices.Length];
        int index = 0;
        foreach (GameObject choice in choices)
        {
            choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!dialogueIsPlaying)
        {
            GameUI.SetActive(true);

            return;
        }

        GameUI.SetActive(false);



        // check for player input to continue to next line
        if (InputManager.GetInstance().GetSubmitPressed())
        {
            ContinueStory();
        }


        if (isGeneric == false)
        {
            if ((int)currentStory.variablesState["affection"] >= 1)
                Heart1.SetActive(true);
            if ((int)currentStory.variablesState["affection"] >= 2)
                Heart2.SetActive(true);
            if ((int)currentStory.variablesState["affection"] >= 3)
                Heart3.SetActive(true);
            if ((int)currentStory.variablesState["affection"] >= 4)
                Heart4.SetActive(true);
            if ((int)currentStory.variablesState["affection"] >= 5)
                Heart5.SetActive(true);
        }
       


    }

    public static DialogueManager GetInstance()
    {
        return instance;
    }

    public void EnterDialogueMode(TextAsset inkJSON)
    {
        Heart1.SetActive(false);
        Heart2.SetActive(false);
        Heart3.SetActive(false);
        Heart4.SetActive(false);
        Heart5.SetActive(false);
        currentStory = new Story(inkJSON.text);
        dialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        if (npcName == "Jennie")
        {
            JenniePortrait.SetActive(true);
        }
        else if (npcName == "Jessica")
        {
            JessicaPortrait.SetActive(true);
        }
        else if (npcName == "Eric")
        {
            EricPortrait.SetActive(true);
        }

        NameTag.text = npcName;

        ContinueStory();


    }

    private void ExitDialogueMode()
    {
        dialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        JenniePortrait.SetActive(false);
        JessicaPortrait.SetActive(false);
        EricPortrait.SetActive(false);
        Heart1.SetActive(false);
        Heart2.SetActive(false);
        Heart3.SetActive(false);
        Heart4.SetActive(false);
        Heart5.SetActive(false);
        dialogueText.text = "";
    }

    private void ContinueStory()
    {
        if (currentStory.canContinue)
        {
            

            dialogueText.text = currentStory.Continue();
            DisplayChoices();
        }
        else 
        {
            if (isGeneric == false)
            {
                // update affection in current scope
                currentAffection = (int)currentStory.variablesState["affection"];


                // update the affection of NPC in the game as a whole
                LevelManager.GetInstance().npcAffection[npcName] += currentAffection;


            }

            LevelManager.GetInstance().DespawnNPC();
            ExitDialogueMode();
        }
    }

    private void DisplayChoices()
    {
        List<Choice> currentChoices = currentStory.currentChoices;

        // defensive check
        if (currentChoices.Count > choices.Length)
        {
            print("current choices is amount " + currentChoices.Count + "with length    " + choices.Length);
            Debug.LogError("More choices than UI can support, number of choices given:  " + currentChoices);
        }

        int index = 0;
        foreach (Choice choice in currentChoices)
        {
            choices[index].gameObject.SetActive(true);
            choicesText[index].text = choice.text;
            index++;
        }

        // go through the remaining choices the UI supports and make sure they're hidden
        for (int i = index; i < choices.Length; i++)
        {
            choices[i].gameObject.SetActive(false);
        }

        StartCoroutine(SelectFirstChoice());
    }

    private IEnumerator SelectFirstChoice()
    {
        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
    }

    public void MakeChoice(int choiceIndex)
    {

        currentStory.ChooseChoiceIndex(choiceIndex);
        // NOTE: The below two lines were added to fix a bug after the Youtube video was made
        InputManager.GetInstance().RegisterSubmitPressed(); // this is specific to my InputManager script


        

        ContinueStory();

        

    }

}