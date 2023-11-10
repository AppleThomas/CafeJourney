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
    [SerializeField] GameObject waterAdded;
    [SerializeField] GameObject milkAdded;
    [SerializeField] GameObject espressoAdded;

    void Start()
    {
        waterButton.SetActive(true);
        // Disable buttons 2 and 3 initially
        milkButton.SetActive(false);
        espressoButton.SetActive(false);
        finishButton.SetActive(false);
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

        // Enable button 2
        milkButton.SetActive(true);
    }

    public void DisableButton2()
    {
        // Disable button 2
        milkButton.SetActive(false);

        // Enable button 3
        espressoButton.SetActive(true);
    }
    public void DisableButton3()
    {
        // Disable button 2
        espressoButton.SetActive(false);

        // Enable button 3
        finishButton.SetActive(true);
    }
    public void DisableButton4()
    {
        SceneManager.LoadScene("CMade");
    }



    public void AddWater()
    {
        waterAdded.SetActive(true);
        Debug.Log("Water added to the coffee machine!");
    }

    public void AddMilk()
    {
        milkAdded.SetActive(true);
        Debug.Log("Milk added to the coffee machine!");
    }

    public void AddEspresso()
    {
        espressoAdded.SetActive(true);
        Debug.Log("Espresso added to the coffee machine!");
    }
}
