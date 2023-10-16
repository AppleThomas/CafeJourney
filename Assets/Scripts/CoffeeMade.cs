using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CoffeeMade : MonoBehaviour
{
    private bool isPlayerInRange;
    public GameObject Coffee;
    public GameObject interactionBox;
    public TextMeshProUGUI interactionText;
    public string signText;

    void Start()
    {
        Coffee.SetActive(true);
    }

    void Update()
    {
        if (isPlayerInRange)
        {
            interactionText.text = signText;
            interactionBox.SetActive(true);
        }
        else
        {
            interactionBox.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F) && isPlayerInRange)
        {
            SceneManager.LoadScene("CMaking");
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