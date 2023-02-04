using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth : Collectable
{
    // Start is called before the first frame update
    [SerializeField] GameObject item;
    protected override void PlayerTriggerEvent (Collider2D _player)
    {
        inventory.instance.AddItem(item);
        base.PlayerTriggerEvent(_player);
     }

 }
