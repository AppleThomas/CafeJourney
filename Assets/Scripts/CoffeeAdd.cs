using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CoffeeAdd : MonoBehaviour
{
    // Attach your buttons to these fields in the Inspector
    [SerializeField] GameObject waterButton;
    [SerializeField] GameObject milkButton;
    [SerializeField] GameObject espressoButton;
    [SerializeField] GameObject finishButton;
    [SerializeField] GameObject retryButton;
    [SerializeField] GameObject exitButton;
    [SerializeField] GameObject waterAdded;
    [SerializeField] GameObject milkAdded;
    [SerializeField] GameObject espressoAdded;
    [SerializeField] GameObject waterBar;
    [SerializeField] GameObject milkBar;
    [SerializeField] GameObject espressoBar;
    [SerializeField] GameObject coffeeMade;
    [SerializeField] GameObject espressoMade;
    [SerializeField] GameObject LatteMade;
    int progress1 = 0;
    int progress2 = 0;
    int progress3 = 0;
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    private bool waterCoffee = false;
    private bool milkCoffee = false;
    private bool espressoCoffee = false;
    private bool waterEspresso = false;
    private bool milkEspresso = false;
    private bool espressoEspresso = false;
    private bool waterLatte = false;
    private bool milkLatte = false;
    private bool espressoLatte = false;
    private bool coffeeMaded = false;
    private bool espressoMaded = false;
    private bool LatteMaded = false;
    public static int maded;
    public TextMeshProUGUI waterText;
    public TextMeshProUGUI milkText;
    public TextMeshProUGUI espressoText;
    public GameObject coffeePanel;
    public bool coffeeOpen;
    public static CoffeeAdd instance;
    private Drink drinkMade;

    void Start()
    {
        
        
    }

    private void Awake()
    {
        coffeePanel.SetActive(false);
        coffeeOpen = false;
        instance = this;
    }

    public void openCoffee()
    {
        coffeePanel.SetActive(true);
        coffeeOpen = true;

        waterButton.SetActive(true);
        exitButton.SetActive(true);
        // Disable buttons 2 and 3 initially
        milkButton.SetActive(false);
        espressoButton.SetActive(false);
        finishButton.SetActive(false);
        waterBar.SetActive(false);
        milkBar.SetActive(false);
        espressoBar.SetActive(false);
        retryButton.SetActive(false);
        coffeeMade.SetActive(false);
        espressoMade.SetActive(false);
        LatteMade.SetActive(false);
        waterText.text = "";
        milkText.text = "";
        espressoText.text = "";
        drinkMade = new Drink();
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



    public void OnButton1Click()
    {
        Invoke("DisableButton1", 5f);
    }
    public void OnButton2Click()
    {
        Invoke("DisableButton2", 5f);
    }
    public void OnButton3Click()
    {
        Invoke("DisableButton3", 5f);
    }
    public void OnButton4Click()
    {
        Invoke("DisableButton4", 1f);
    }

    public void DisableButton1()
    {
        // Disable button 1
        waterButton.SetActive(false);
        waterBar.SetActive(false);
        waterText.text = "";

        // Enable button 2
        milkButton.SetActive(true);
        
    }

    public void DisableButton2()
    {
        // Disable button 2
        milkButton.SetActive(false);
        milkBar.SetActive(false);
        milkText.text = "";


        // Enable button 3
        espressoButton.SetActive(true);
       
    }
    
    public void DisableButton3()
    {
        // Disable button 3
        espressoButton.SetActive(false);
        espressoBar.SetActive(false);
        espressoText.text = "";

        if (waterCoffee && milkCoffee && espressoCoffee)
        {
            coffeeMaded = true;
        }
        if(waterEspresso && milkEspresso && espressoEspresso)
        {
            espressoMaded = true;
        }
        if(waterLatte && milkLatte && espressoLatte)
        {
            LatteMaded = true;
        }
        // Enable button 4
        if (coffeeMaded)//made coffee
        {
            maded = 1;
            coffeeMade.SetActive(true);
            finishButton.SetActive(true);
        } 
        if (espressoMaded)//made espresso
        {
            maded = 2;
            espressoMade.SetActive(true);
            finishButton.SetActive(true);
        }
        if (LatteMaded)//made latte
        {
            maded = 3;
            LatteMade.SetActive(true);
            finishButton.SetActive(true);
        } 
        if ((!coffeeMaded) && (!espressoMaded) && (!LatteMaded))
        {
            exitButton.SetActive(false);
            retryButton.SetActive(true);
        }
    }
    public void RetryButton()
    {
        openCoffee();

    }


    //public void DisableButton4()
    //{
    //    SceneManager.LoadScene("CMade");
    //}

    public void AddWater()
    {
        waterAdded.SetActive(true);
        waterBar.SetActive(true);
        Debug.Log("Water added to the coffee machine!");
    }

    public void AddMilk()
    {
        milkAdded.SetActive(true);
        milkBar.SetActive(true);
        Debug.Log("Milk added to the coffee machine!");
    }

    public void AddEspresso()
    {
        espressoAdded.SetActive(true);
        espressoBar.SetActive(true);
        Debug.Log("Espresso added to the coffee machine!");
    }

    public void UpdateSlider1()    //Progress bars
    {
        
        progress1++;
        slider1.value = progress1;
        waterText.text = slider1.value.ToString();

        if (slider1.value == 10)
        {
            waterCoffee = true;
            waterEspresso = false;
            waterLatte = false;
        }
        if (slider1.value == 5)
        {
            waterEspresso = true;
            waterLatte = false;
            waterCoffee = false;

        }
        if (slider1.value == 8)
        {
            waterLatte = true;
            waterCoffee = false;
            waterEspresso = false;
        }

    }
    public void UpdateSlider2()    //Progress bars
    {
        progress2++;
        slider2.value = progress2;
        milkText.text = slider2.value.ToString();

        if (slider2.value == 10)
        {
            milkCoffee = true;
            milkEspresso = false;
            milkLatte = false;
        }
        if (slider2.value == 5)
        {
            milkEspresso = true;
            milkLatte = false;
            milkCoffee = false;
        }
        if (slider2.value == 20)
        {
            milkLatte = true;
            milkCoffee = false;
            milkEspresso = false;
        }

    }
    public void UpdateSlider3()    //Progress bars
    {
        progress3++;
        slider3.value = progress3;
        espressoText.text = slider3.value.ToString();

        if (slider3.value == 10)
        {
            espressoCoffee = true;
            espressoEspresso = false;
            espressoLatte = false;
        }
        if (slider3.value == 20)
        {
            espressoEspresso = true;
            espressoLatte = false;
            espressoCoffee = false;
        }
        if (slider3.value == 15)
        {
            espressoLatte = true;
            espressoCoffee = false;
            espressoEspresso = false;
        }

    }
}
