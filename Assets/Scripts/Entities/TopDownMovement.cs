using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator _anim;

    [SerializeField] private SpriteRenderer characterRenderer;

    Vector2 mouse;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);

        // Character look at mouse pointer (only x position)
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        characterRenderer.flipX = mouse.x < transform.position.x;

        if (_rigidbody.velocity != Vector2.zero) _anim.SetTrigger("isWalk");
        else _anim.SetTrigger("isIdle");
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }
}