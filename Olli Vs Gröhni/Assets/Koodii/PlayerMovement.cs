using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;

    Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) )
        {
            body.velocity = new Vector2(body.velocity.x,speed);
        }
        anim.SetFloat("Velocity", body.velocity.magnitude);

        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("Punch");
        }
    }
}
