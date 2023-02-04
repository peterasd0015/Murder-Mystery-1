using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloth1 : Collectable
{
    GameObject item;
    protected override void PlayerTriggerEvent (Collider2D _Player)
    {
        //Gives to player cloth
        base.PlayerTriggerEvent(_Player);
    }
}
