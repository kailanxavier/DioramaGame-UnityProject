using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Barrel : BaseInteractable
{
    protected override void Interact()
    {
        Debug.Log("Interacted with Barrel");
    }
}
