using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // to keep track of each NPC progress, make bool dictionary to know if we open a file or not

    void Awake()
    {


        if (instance != null)
        {
            Debug.LogError("Found more than one Level Manager in the scene.");
        }
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        //print("Current level is: " + level);
    }

    public void LevelUp()
    {
        level++;
    }

    public static LevelManager GetInstance()
    {
        return instance;
    }


}
