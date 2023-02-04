using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : MonoBehaviour
{
    public enum Types
    {
        Weapon,
        Armor,
        Book,
        Others

     }
    public Types itemType;

    public virtual void DropEvent()
    {
        Debug.Log("DropEvent");


    }
}
