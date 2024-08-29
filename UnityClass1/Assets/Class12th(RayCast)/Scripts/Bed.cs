using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour, IInterractable
{
    public void Interact()
    {
        Debug.Log("It is a Bed");
    }
}
