using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


// use coffee add
public class CoffeeMachineInteraction : MonoBehaviour
{
    private bool isPlayerInRange;
    public GameObject interactionVisual;
    



    void Update()
    {
        if (isPlayerInRange && !CoffeeAdd.getInstance().coffeeOpen)
        {   
            //interactionText.text = signText;
            interactionVisual.SetActive(true);
        }
        else
        {
            interactionVisual.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F) && isPlayerInRange)
        {
            CoffeeAdd.getInstance().openCoffee();
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