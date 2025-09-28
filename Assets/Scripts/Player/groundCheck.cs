using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    private float extraHeight = 0.25f;
    private LayerMask whatIsGround;

    private RaycastHit2D groundHit;

    private Collider2D coll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    public bool IsGrounded()
    {
        groundHit = Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, extraHeight, whatIsGround);

        if (groundHit.collider != null)
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
