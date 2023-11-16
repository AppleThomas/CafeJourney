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

    void Start()
    {

    }

    void Update()
    {
        if (isPlayerInRange)
        {
            menu.SetActive(true);
            menuInteraction.SetActive(true);
        }
        else
        {
            menu.SetActive(false);
            menuInteraction.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F) && isPlayerInRange)
        {
            SceneManager.LoadScene("DrinkMenu");
        }
    }
    public void Exiting()
    {
        SceneManager.LoadScene("Tutorial");
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
