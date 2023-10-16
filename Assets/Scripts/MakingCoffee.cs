using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoffeeMaking : MonoBehaviour
{
    public float coffeeMakingTime = 10f; 
    public GameObject Drinks;

    private float timeLeft;

    private void Start()
    {
        timeLeft = coffeeMakingTime;
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        
        if (timeLeft <= 0f )
        {
            SceneManager.LoadScene("CMade");
        }
    }
}
