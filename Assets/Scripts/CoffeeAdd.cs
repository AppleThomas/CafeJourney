using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoffeeAdd : MonoBehaviour
{
    // Attach your buttons to these fields in the Inspector
    [SerializeField] GameObject waterButton;
    [SerializeField] GameObject milkButton;
    [SerializeField] GameObject espressoButton;
    [SerializeField] GameObject finishButton;
    [SerializeField] GameObject retryButton;
    [SerializeField] GameObject waterAdded;
    [SerializeField] GameObject milkAdded;
    [SerializeField] GameObject espressoAdded;
    [SerializeField] GameObject waterBar;
    [SerializeField] GameObject milkBar;
    [SerializeField] GameObject espressoBar;
    int progress1 = 0;
    int progress2 = 0;
    int progress3 = 0;
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    private bool waterFull = false;
    private bool milkFull = false;
    private bool espressoFull = false;

    void Start()
    {
        waterButton.SetActive(true);
        // Disable buttons 2 and 3 initially
        milkButton.SetActive(false);
        espressoButton.SetActive(false);
        finishButton.SetActive(false);
        waterBar.SetActive(false);
        milkBar.SetActive(false);
        espressoBar.SetActive(false);
        retryButton.SetActive(false);
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
        Invoke("DisableButton4", 2f);
    }

    public void DisableButton1()
    {
        // Disable button 1
        waterButton.SetActive(false);
        waterBar.SetActive(false);

        // Enable button 2
        milkButton.SetActive(true);
        
    }

    public void DisableButton2()
    {
        // Disable button 2
        milkButton.SetActive(false);
        milkBar.SetActive(false);
       

        // Enable button 3
        espressoButton.SetActive(true);
       
    }
    public void DisableButton3()
    {
        // Disable button 3
        espressoButton.SetActive(false);
        espressoBar.SetActive(false);

        // Enable button 4
        if (waterFull && milkFull && espressoFull)
        {
            finishButton.SetActive(true);
        } else
        {
            retryButton.SetActive(true);
        }
    }
    public void RetryButton()
    {
        SceneManager.LoadScene("CMaking");
    }


    public void DisableButton4()
    {
        SceneManager.LoadScene("CMade");
    }

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
        if(slider1.value == 12)
        {
            waterFull = true;
        }
        
    }
    public void UpdateSlider2()    //Progress bars
    {
        progress2++;
        slider2.value = progress2;
        if (slider2.value == 8)
        {
            milkFull = true;
        }

    }
    public void UpdateSlider3()    //Progress bars
    {
        progress3++;
        slider3.value = progress3;
        if (slider3.value == 15)
        {
            espressoFull = true;
        }

    }
}
