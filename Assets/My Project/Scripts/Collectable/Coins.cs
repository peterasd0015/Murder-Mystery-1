using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : Collectable
{
    [SerializeField] int value;
    protected override void PlayerTriggerEvent(Collider2D _player)
    {
        inventory.instance.AddCoins (value);
        //_player.GetComponent<PlayerControl>().AddCoin(value);
        base.PlayerTriggerEvent(_player);
        
    }

}
