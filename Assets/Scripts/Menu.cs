using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    private bool isPlayerInRange;
    public GameObject menu;
    public GameObject menuInteraction;


    void Update()
    {

        if (isPlayerInRange && !(MenuCanvas.getInstance().menuIsOpen))
        {
            menuInteraction.SetActive(true);

        }
        else
        {
            menuInteraction.SetActive(false);
        }
        if (isPlayerInRange)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                MenuCanvas.getInstance().openMenu();

            }
        }
    }

 

    void OnTriggerEnter2D(Collider2D other)
    {
        isPlayerInRange = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        isPlayerInRange = false;
    }

  
}
