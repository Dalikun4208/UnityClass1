using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour, IInterractable
{
    public void Interact()
    {
        Debug.Log("It is a table");
    }
}
