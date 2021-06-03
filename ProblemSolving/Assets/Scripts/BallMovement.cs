using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public static BallMovement Instance { get; private set;}

    private Rigidbody2D rb2;
    public Collider2D coll;

    public Vector2 direction;
    public float speed = 50.0f;

    private Camera mainCamera;

    private void Awake()
    {
        Instance = this;

        rb2 = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;

        //direction = (mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position).normalized;
        //Vector3 target = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        rb2.velocity = direction;
        //rb2.MovePosition((Vector2)transform.position + direction * speed);
    }
}
