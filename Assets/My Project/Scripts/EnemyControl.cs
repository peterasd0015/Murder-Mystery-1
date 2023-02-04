using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class EnemyControl : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float attackRange;

    private Animator anim;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Transform player;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        Animations();
        
    }
    private void FixedUpdate()
    {
        float _distancetoPlayer = Vector2.Distance(player.position, transform.position);
        if (_distancetoPlayer > attackRange)
        {
            direction = player.position - transform.position;
            direction = direction.normalized;
        }
        else
        {
            direction = Vector2.zero;
        }
        rb.velocity = direction * speed;
    }

    void Animations()
    {
        anim.SetFloat("SpeedX", direction.x);
        anim.SetFloat("SpeedY", direction.y);
    }
}
