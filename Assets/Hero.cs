using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    bool isGround = true;
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, 0);
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(new Vector2(0, jumpForce),
                ForceMode2D.Impulse);
        }
    }
}
