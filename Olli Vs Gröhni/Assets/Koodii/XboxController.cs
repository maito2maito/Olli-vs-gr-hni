using UnityEngine;

public class XboxController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Rigidbody2D rb;

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Hyppääminen A-napilla
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
