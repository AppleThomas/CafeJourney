using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeManager : MonoBehaviour
{
    private static CoffeeManager instance;
    public List<Drink> DrinkList = new List<Drink>();
    public Drink currentDrink;
    public bool coffeeDone = false;
  
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
            water = 1,
            milk = 1,
            espresso = 10
        });

        DrinkList.Add(new Drink
        {
            drinkName = "Latte",
            water = 3,
            milk = 8,
            espresso = 5
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
        Debug.Log("randomizing drink");
        currentDrink = DrinkList[Random.Range(0, DrinkList.Count)];
        coffeeDone = false;
    }

    public static CoffeeManager GetInstance()
    {
        return instance;
    }
}
