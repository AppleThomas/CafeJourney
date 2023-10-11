using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoffeeMaking : MonoBehaviour
{
    public float coffeeMakingTime = 10f; // Time in seconds to make the coffee.
    public Text timerText; // Reference to a UI text element displaying the timer.

    private float timeLeft;

    private void Start()
    {
        timeLeft = coffeeMakingTime;
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            // Coffee is ready, return to the main game scene.
            SceneManager.LoadScene("Tutorial"); // Replace with the name of your main game scene.
        }

        // Update the timer display.
        //timerText.text = "Time left: " + Mathf.Ceil(timeLeft).ToString();
    }
}
