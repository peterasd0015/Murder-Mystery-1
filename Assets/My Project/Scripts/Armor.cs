using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : InventoryItem
{
    [SerializeField] RuntimeAnimatorController controller;
    public override void DropEvent()
    {
        base.DropEvent();
        PlayerControl.instance.UpdateController(controller);

    }

}
