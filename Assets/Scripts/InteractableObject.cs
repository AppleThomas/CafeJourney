using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public void OnInteract()
    {
        Debug.Log("You used" + name);
    }
}
