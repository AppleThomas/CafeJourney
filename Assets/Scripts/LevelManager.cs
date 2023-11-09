using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public int level = 0;
    private static LevelManager instance;
    // Start is called before the first frame update
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
        print("Current level is: " + level);
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
