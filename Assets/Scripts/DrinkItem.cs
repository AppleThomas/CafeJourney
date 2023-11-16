using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class DrinkItem : MonoBehaviour
{
    private bool isPlayerInRange;
    [SerializeField] GameObject drink1;
    [SerializeField] GameObject drink2;
    [SerializeField] GameObject drink3;


    void Start()
    {
        drink1.SetActive(false);
        drink2.SetActive(false);
        drink3.SetActive(false);
        
    }

    void Update()
    {
        if (CoffeeAdd.maded == 1)
        {
            drink1.SetActive(true);
        }
        if (CoffeeAdd.maded == 2)
        {
            drink2.SetActive(true);
        }
        if (CoffeeAdd.maded == 3)
        {
            drink3.SetActive(true);
        }

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