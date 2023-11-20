using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CoffeeAdd : MonoBehaviour
{
    
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;

    public static int maded;
    public TextMeshProUGUI waterText;
    public TextMeshProUGUI milkText;
    public TextMeshProUGUI espressoText;
    public TextMeshProUGUI coffeeName;
    public TextMeshProUGUI errorText;
    public GameObject coffeePanel;
    public bool coffeeOpen;
    public static CoffeeAdd instance;
    private Drink drinkMade;
    private Drink desiredCoffee;

    void Update()
    {
        UpdateWaterSlider();
        UpdateMilkSlider();
        UpdateEspressoSlider();


    }

    private void Awake()
    {
        coffeePanel.SetActive(false);
        coffeeOpen = false;
        instance = this;
        drinkMade = new Drink();
    }

    public void openCoffee()
    {
        desiredCoffee = CoffeeManager.GetInstance().currentDrink;
        if (desiredCoffee != null)
        {
            coffeeName.text = desiredCoffee.drinkName;
        }
        else
        {
            coffeeName.text = "N/A";
        }
        coffeePanel.SetActive(true);
        errorText.text = "";
        coffeeOpen = true;

    }

    public void exitCoffee()
    {
        
        coffeeOpen = false;
        coffeePanel.SetActive(false);
    }

    public static CoffeeAdd getInstance()
    {
        return instance;
    }

    
    public void RetryButton()
    {
        drinkMade.water = 0;
        drinkMade.milk = 0;
        drinkMade.espresso = 0;

    }

    public void FinishButton()
    {
        desiredCoffee = CoffeeManager.GetInstance().currentDrink;
        if (desiredCoffee != null)
        {
            if (drinkMade.water == desiredCoffee.water &&
                drinkMade.milk == desiredCoffee.milk &&
                drinkMade.espresso == desiredCoffee.espresso)
            {
                exitCoffee();
            }
            else
            {
                errorText.text = "Incorrect Recipe Please Try Again";
            }
        }
        else
        {
            errorText.text = "No Order Taken Yet";
        }
    }


    public void AddWater()
    {
        drinkMade.water++;
        
    }

    public void AddMilk()
    {
        drinkMade.milk++;
    }

    public void AddEspresso()
    {
        drinkMade.espresso++;
    }

    public void RemoveWater()
    {
        drinkMade.water--;

    }

    public void RemoveMilk()
    {
        drinkMade.milk--;
    }

    public void RemoveEspresso()
    {
        drinkMade.espresso--;
    }

    public void UpdateWaterSlider()    //Progress bars
    {

        slider1.value = drinkMade.water;
        waterText.text = slider1.value.ToString();

        

    }
    public void UpdateMilkSlider()    //Progress bars
    {
        slider2.value = drinkMade.milk;
        milkText.text = slider2.value.ToString();

       

    }
    public void UpdateEspressoSlider()    //Progress bars
    {
        slider3.value = drinkMade.espresso;
        espressoText.text = slider3.value.ToString();

  
    }
}
