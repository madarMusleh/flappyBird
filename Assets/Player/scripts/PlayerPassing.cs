using UnityEngine;
using TMPro;

public class PlayerPassing : MonoBehaviour
{
    public LayerMask passing;
    public int howManyBoxesPassed = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    private bool _wasInsideLastFrame = false;

    void Update()
    {
        // Check if the detection circle is overlapping the passing layer
        bool isCurrentlyInside = Physics2D.OverlapCircle(transform.position, 0.3f, passing);

        // ONLY trigger on the exact frame the player ENTERS the zone
        if (isCurrentlyInside && !_wasInsideLastFrame)
        {
            howManyBoxesPassed++;
            updateScore();
        }

        // Save the current state for the next frame's comparison
        _wasInsideLastFrame = isCurrentlyInside;
    }

    void updateScore()
    {
        scoreText.text = howManyBoxesPassed.ToString();
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.3f);
    }
}