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


    void Awake()
    {
        

        if (instance != null)
        {
            Debug.LogError("Found more than one Level Manager in the scene.");
        }
        instance = this;
    }

    public void Start()
    {
        Jennie.SetActive(false);
        Eric.SetActive(false);
        Jessica.SetActive(false);
        GenericNPC.SetActive(false);

        
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
            npcList.Add("GenericNPC");
        }

        //print("ordered is ");
        //foreach (KeyValuePair<string, int> kvp in npcAffection)
        //    print("Key = " + kvp.Key +  "Value = " + kvp.Value);

        string lowestNPC = npcAffection.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
   
        npcList.Add(lowestNPC);


        SpawnNPC();
    }

    public void SpawnNPC()
    {

        string firstNPC = npcList.First();

        FindInActiveObjectByName(firstNPC).SetActive(true);
        
        
    }

    public void DespawnNPC()
    {
        print("POP");
        GameObject.Find(npcList.First()).SetActive(false);
        npcList.RemoveAt(0);

        if (npcList.Count != 0)
        {
            SpawnNPC();
        }

    }

    public static LevelManager GetInstance()
    {
        return instance;
    }

    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }


}
