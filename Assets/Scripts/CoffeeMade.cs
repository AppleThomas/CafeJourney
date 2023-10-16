using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeMade : MonoBehaviour
{
    private bool isPlayerInRange;
    public GameObject Coffee;

    void Start()
    {
        Coffee.SetActive(true);
    }

    void Update()
    {
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