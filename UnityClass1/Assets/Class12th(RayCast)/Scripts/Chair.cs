using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour, IInterractable
{
    public void Interact()
    {
        Debug.Log("It is a Chair");
    }
}
