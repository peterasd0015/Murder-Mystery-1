using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour
{
    private Vector2 lastClickedPos;
    bool moving;
    public static PlayerControl instance;
    [SerializeField] float speed;
    Rigidbody2D rb;
    Animator anim;
    float x, y;

    int coins;
    private void Awake()
    {
        instance = this;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update ()
    {
        Animations();
        Inputs();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x, y)*speed;
    }
    void Inputs()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            x = 1f;
            y = 0f;
            moving=false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            x = -1f;
            y = 0f;
            moving=false;
        }
        else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            x = 0f;
            y = 1f;
            moving=false;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            x = 0f;
            y = -1f;
            moving=false;
        }
         
        else if (Input.GetMouseButton(0)){
            lastClickedPos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving=true;
             }
        else if (moving && (Vector2)transform.position != lastClickedPos)
        {
            float step= speed*Time.deltaTime;
            transform.position=Vector2.MoveTowards(transform.position, lastClickedPos, step);
        } 
        else
        {
            moving =false;
            x = 0f;
            y = 0f;            
        }

    }

    void Animations()
    {
        anim.SetFloat("SpeedX", x);
        anim.SetFloat("SpeedY", y);
    }
    public void AddCoin(int _value)
    {
        //coins++;
        coins += _value;
        Debug.Log(coins);
    }
    public void UpdateController(RuntimeAnimatorController _newcontroller)
    {
        anim.runtimeAnimatorController = _newcontroller;
    }
    
}


