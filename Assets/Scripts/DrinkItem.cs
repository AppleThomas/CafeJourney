using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DrinkItem : MonoBehaviour
{
    private bool isPlayerInRange;


    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && isPlayerInRange)
        {
            Destroy(gameObject);
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