using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float AxV, AxH;
    public float speed;
    Rigidbody2D RB2D;
    Vector2 dir;

    private void Awake()
    {
        RB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        AxV = Input.GetAxisRaw("Vertical");
        AxH = Input.GetAxisRaw("Horizontal");

        if (AxV != 0)
        {
            AxH = 0;
            dir = new Vector2(0, AxV);
        }
        else
        {
            AxV = 0;
            dir = new Vector2(AxH, 0);
        }
    }

    private void FixedUpdate()
    {
        Walk();
    }

    void Walk()
    {
        if (dir != Vector2.zero)
        {
            RB2D.AddForce(dir.normalized * speed, ForceMode2D.Force);
        }
        else
        {
            RB2D.velocity = Vector2.zero;
        }

        if (AxH == 0)
        {
            RB2D.velocity = new Vector2(0, RB2D.velocity.y);
        }
        if (AxV == 0)
        {
            RB2D.velocity = new Vector2(RB2D.velocity.x, 0);
        }
    }
}
