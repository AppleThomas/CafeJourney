using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCanvas : MonoBehaviour
{
    public GameObject DrinkMenuPanel;
    public bool menuIsOpen;
    public static MenuCanvas instance;
    // Start is called before the first frame update
    void Awake()
    {
        DrinkMenuPanel.SetActive(false);
        menuIsOpen = false;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static MenuCanvas getInstance()
    {
        return instance;
    }

    public void openMenu()
    {
        if (menuIsOpen)
        {
            return;
        }
        DrinkMenuPanel.SetActive(true);
        menuIsOpen = true;
    }

    public void exitMenu()
    {
        menuIsOpen = false;
        DrinkMenuPanel.SetActive(false);
    }
}
