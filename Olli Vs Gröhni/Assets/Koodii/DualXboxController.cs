using UnityEngine;

public class DualXboxController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public int playerNumber; // Player 1 or Player 2

    void Update()
    {
        string horizontalAxis = "Horizontal" + playerNumber;
        string jumpButton = "Jump" + playerNumber;

        float moveInput = Input.GetAxis(horizontalAxis);
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown(jumpButton))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
