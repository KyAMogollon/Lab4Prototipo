using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    private SpriteRenderer _sp;
    private Rigidbody2D _rb;
    public float speed;
    Vector3 movementPlayer;
    public int life = 10;

    [Header("Jump")]
    public bool suelo;
    public bool isJump;
    public float jumpForce;
    public LayerMask mylayermask;
    public int currentSalto;
    [Header("PowerUp")]
    public Image[] images;
    // Start is called before the first frame update
    void Start()
    {
        _sp = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

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
    public void OnColorRed(InputAction.CallbackContext value)
    {
        if(value.started)
        {
            _sp.color = Color.red;
            images[0].color = new Color32(255, 0, 0, 255);
            images[1].color = new Color32(0,255,0,100);
            images[2].color = new Color32(0,0,255,100);
        }
    }
    public void OnColorBlue(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            _sp.color=Color.blue;
            images[1].color = new Color32(0, 255, 0, 100);
            images[0].color = new Color32(255, 0, 0, 100);
            images[2].color = new Color32(0, 0, 255, 255);
        }
    }
    public void OnColorGreen(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            _sp.color = Color.green;
            images[1].color = new Color32(0, 255, 0, 255);
            images[0].color = new Color32(255, 0, 0, 100);
            images[2].color = new Color32(0, 0, 255, 100);
        }
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
