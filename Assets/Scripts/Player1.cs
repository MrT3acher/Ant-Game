using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private int Speed = 5;
    private Rigidbody2D Rg;
    void Move()
    {
        float LR = Input.GetAxis("Horizontal1");
        float UD = Input.GetAxis("Vertical1");
        Vector2 vel = Rg.velocity;
        vel.x = LR * Speed;
        vel.y = UD * Speed;
        Rg.velocity = vel;

    }
    void Awake()
    {
        Rg = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Move();
    }
}
