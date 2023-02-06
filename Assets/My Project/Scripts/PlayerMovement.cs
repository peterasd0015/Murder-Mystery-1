using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int speed = 5;
 public Vector2 movement;
 private Rigidbody2D rb;
 private Animator animator;

private void Awake ()
    {
    rb=GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
    }
    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();
 
            

            if (movement.x!=0 || movement.y !=0)
            {
                animator.SetBool("Is Running", true);
                animator.SetFloat("X", movement.x);
                animator.SetFloat("Y", movement.y);
             }
            else
             {
               animator.SetBool("Is Running", false);
             }
    }
             
             private void Flip()
             {
                

                // Rotate the player
                if (movement.x>0)
                {
                    transform.Rotate(0f, 180f, 0f);
                }
                   if (movement.x<0)

                {
                    transform.Rotate(0f, -180f, 0f);
                }
             }
    // player flip point of attck also flip is direction
    //transform.Rotate(0f, 180f, 0f);
    
        private void FixedUpdate ()
    {
//v1
rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

//v2
//if (movement.x!=0 || ,movement.y !=0)
//{}
//rb.velocity = movement * speed;
//}
   }
}