using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    [SerializeField] int attack = 25;
    [SerializeField] float power = 250f;

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody2D.velocity = Vector2.up * power * Time.fixedDeltaTime;    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Enemy>().OnHit(attack);
    }
}
