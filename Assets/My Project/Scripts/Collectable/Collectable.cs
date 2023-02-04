using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    protected void OnTriggerEnter2D(Collider2D _other)
    {
        if (_other.CompareTag("Player"))
        {
            PlayerTriggerEvent(_other);
           /* _other.GetComponent<PlayerControl>().AddCoin(value);
            Destroy(gameObject); */
        }

        //Debug.Log("OnTriggerEnter2D");
    }
    /* private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit");
    }
     */
    protected virtual void PlayerTriggerEvent(Collider2D _player)
    {
        Debug.Log("PlayerTriggerEvent");

        //_player.GetComponent<PlayerControl>().AddCoin(value);
        Destroy(gameObject);
    }
    

}

