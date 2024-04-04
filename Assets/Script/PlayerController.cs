using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer _sp;
    private Rigidbody2D _rb;
    public float speed;
    Vector3 movementPlayer;
    public bool suelo;
    public bool isJump;
    public float jumpForce;
    public LayerMask mylayermask;
    public int currentSalto;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down, Color.red);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        suelo = Physics2D.Raycast(transform.position, Vector3.down, 0.5f, mylayermask);
        _rb.velocity = new Vector2(movementPlayer.x * speed, _rb.velocity.y);
    }
    public void OnMovement(InputAction.CallbackContext value)
    {
        float movement = value.ReadValue<float>();
        movementPlayer = new Vector2 (movement,0);
    }
    public void OnJump(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            Debug.Log("Saltando");
            ValidateJump();
        }
    }
    void OnUpdateColor()
    {

    }
    private void ValidateJump()
    {
        if (suelo)
        {
            isJump = true;
            if (isJump)
            {
                _rb.AddForce(Vector2.up*jumpForce, ForceMode2D.Impulse);
                currentSalto++;
                isJump = false;
            }

        }
        else
        {
            if (currentSalto == 1)
            {
                _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                currentSalto = 0;
            }
        }
    }
    void ValidateChangeColor()
    {

    }
    void StopController()
    {

    }
}
