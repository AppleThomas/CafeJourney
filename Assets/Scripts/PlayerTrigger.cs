using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private Collider2D z_Collider;
    //[SerializeField] private ContactFilter2D z_Filter;
    private List<Collider2D> z_CollidedObjects = new List<Collider2D>(1);
    public bool isInBox;
    private

    void Start()
    {
        z_Collider = GetComponent<Collider2D>();

    }

    void Update()
    {
        foreach (var o in z_CollidedObjects)
        {
            OnCollided(o.gameObject);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Interactable"))
        {
            z_CollidedObjects.Add(other);
            isInBox = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            z_CollidedObjects.Clear();
            isInBox = false;
        }
    }

    protected virtual void OnCollided(GameObject collidedObject)
    {
        Debug.Log("Next to " + collidedObject.name);
    }


}
