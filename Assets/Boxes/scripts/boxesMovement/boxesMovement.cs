using UnityEngine;

public class boxesMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = -5f;
    
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        Move();

        if (transform.position.x < -5)
        {
            Destroy(gameObject);
        }
    }

    private void Move()
    {
        _rb.linearVelocity = new Vector2(speed, _rb.linearVelocity.y);
    }
}
