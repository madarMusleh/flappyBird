using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerJumping : MonoBehaviour
{
    private Player _player;
    
    public float jumpForce = 9f;

    void Awake()
    {
        _player = GetComponent<Player>();
    }


    public void Jump(InputAction.CallbackContext context)
    {
        _player.rb.linearVelocity = new Vector2(_player.rb.linearVelocity.x, jumpForce);
    }
}