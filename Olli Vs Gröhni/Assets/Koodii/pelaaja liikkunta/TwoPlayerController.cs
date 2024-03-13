using UnityEngine;

public class TwoPlayerController : MonoBehaviour
{
    public string horizontalAxisName;
    public string verticalAxisName;
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis(horizontalAxisName);
        float moveY = Input.GetAxis(verticalAxisName);

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement * moveSpeed;
    }
}
