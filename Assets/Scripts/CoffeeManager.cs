using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeManager : MonoBehaviour
{
    private static CoffeeManager instance;
    public List<Drink> DrinkList = new List<Drink>();
    public Drink currentDrink;
    // Start is called before the first frame update
    private void Start()
    {
        DrinkList.Add(new Drink {
            drinkName = "Coffee",
            water = 10,
            milk = 10,
            espresso = 10
        });

        DrinkList.Add(new Drink
        {
            drinkName = "Espresso",
            water = 5,
            milk = 5,
            espresso = 20
        });

        DrinkList.Add(new Drink
        {
            drinkName = "Latte",
            water = 8,
            milk = 20,
            espresso = 15
        });

    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void getRandomDrink()
    {
        currentDrink = DrinkList[Random.Range(0, DrinkList.Count)];
    }

    public static CoffeeManager GetInstance()
    {
        return instance;
    }
}
