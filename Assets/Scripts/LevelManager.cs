using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelManager : MonoBehaviour
{

    public int level = 0;
    private static LevelManager instance;

    // NPC's, stirng is name, int is affection
    public Dictionary<string, int> npcAffection = new Dictionary<string, int>()
    {
        {"Jennie", 0 },
        {"Eric", 0 },
        {"Jessica", 0}
    };

    public List<string> npcList = new List<string>();

    // NPC objects
    [SerializeField] private GameObject Jennie;
    [SerializeField] private GameObject Eric;
    [SerializeField] private GameObject Jessica;
    [SerializeField] private GameObject GenericNPC;



    // to keep track of each NPC progress, make bool dictionary to know if we open a file or not

    void Awake()
    {
        

        if (instance != null)
        {
            Debug.LogError("Found more than one Level Manager in the scene.");
        }
        instance = this;


        //Jennie.SetActive(false);
        //Eric.SetActive(false);
        //Jessica.SetActive(false);
        //GenericNPC.SetActive(false);
    }

    public void Start()
    {
        
        Jennie.SetActive(false);
        Eric.SetActive(false);
        Jessica.SetActive(false);
        GenericNPC.SetActive(false);

        print("yeehawww" + Jennie.name);
    }

    // Update is called once per frame
    void Update()
    {
        // level up!
        if (npcList.Count == 0 )
        {
            print("level is:    " + level);
            LevelUp();
        }
    }

    public void LevelUp()
    {
        level++;

        // sets the npclist for current level
        for (int i = 0; i < 4; i++)
        {
            npcList.Add("NPC");
        }

        var lowestNPC = npcAffection.OrderByDescending(pair => pair.Value).Take(1);
        // add lowest level npc to level
        foreach (var person in lowestNPC)
        {
            npcList.Add(person.Key);
        }

        print("people in this level is  ");
        foreach (var x in npcList)
        {
            print(x.ToString());
        }
    }

    public static LevelManager GetInstance()
    {
        return instance;
    }


}
