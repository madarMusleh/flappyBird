using UnityEngine;

public class Player : MonoBehaviour
{
    public LayerMask death;
    private PlayerControls _playerControls;
    public Rigidbody2D rb;
    private PlayerJumping _playerJumping;
    public Collider2D col;


    void Awake()
    {
        col = GetComponent<Collider2D>();
        _playerControls = new PlayerControls();
        rb = GetComponent<Rigidbody2D>();
        _playerJumping = GetComponent<PlayerJumping>();

        rb.gravityScale = 3.5f;
        _playerControls.Player.Jump.performed += _playerJumping.Jump;
    }


    void OnEnable()
    {
        _playerControls.Enable();
    }


    void OnDisable()
    {
        _playerControls.Disable();
    }
}