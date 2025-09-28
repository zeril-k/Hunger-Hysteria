using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointSaver : MonoBehaviour
{
    public LayerMask whatIsCheckPoint;

    public Vector2 SafeGroundLocation { get; private set; } = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SafeGroundLocation = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((whatIsCheckPoint.value & (1 << collision.gameObject.layer)) > 0)
        {
            SafeGroundLocation = new Vector2(collision.bounds.center.x, collision.bounds.min.y);
        }
    }

    public void warpPlayerToSafeGround()
    { 
        transform.position = SafeGroundLocation;
    }
}
