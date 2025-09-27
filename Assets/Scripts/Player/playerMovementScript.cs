using UnityEngine;

public class playerMovementScript : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private SpriteRenderer spriteRenderer;

    public chemicalManager cm;
    public humanManager hm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        if (moveInput > 0)
        {
            spriteRenderer.flipX = false;
        }

        if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Chemical"))
        {
            Destroy(other.gameObject);
            cm.chemicalCount++;
        }

        if (other.gameObject.CompareTag("Human"))
        {
            Destroy(other.gameObject);
            hm.pointsCount++;
        }
    }
}
