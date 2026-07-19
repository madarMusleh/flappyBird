using UnityEngine;

public class DetectorMovement : MonoBehaviour
{
    public float speed = -3f; 

    void FixedUpdate()
    {
        transform.Translate(new Vector3(speed * Time.fixedDeltaTime, 0, 0));

        if (transform.position.x < -5f)
        {
            Destroy(gameObject);
        }
    }
}