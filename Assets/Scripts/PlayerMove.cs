using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D _body;

    private float _horizontal;
    private float _vertical;

    public float runSpeed = 20.0f;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        _horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        _vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
        _body.velocity = new Vector2(_horizontal * runSpeed, _vertical * runSpeed);
    }
}
