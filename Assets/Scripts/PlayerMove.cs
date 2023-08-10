using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D _body;
    private float _horizontal;
    private float _vertical;

    public float runSpeed = 20.0f;

    public Joystick joystick;

    void Start()
    {
        _body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        _horizontal = joystick.Horizontal * runSpeed; // -1 is left
        _vertical = joystick.Vertical * runSpeed; // -1 is down
    }

    void FixedUpdate()
    {
        _body.velocity = new Vector2(_horizontal, _vertical);
    }
}
