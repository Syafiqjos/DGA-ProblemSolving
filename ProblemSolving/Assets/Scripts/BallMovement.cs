using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb2;

    public Vector2 direction;
    public float speed = 50.0f;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        direction = Random.insideUnitCircle;
    }

    private void Start()
    {
        rb2.AddForce(direction * speed, ForceMode2D.Impulse);
    }
}
