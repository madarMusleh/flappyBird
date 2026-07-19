using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Player _player;
    public float radius = 0.3f;

    public bool isDead;
    
    void Awake()
    {
        _player = GetComponent<Player>();
    }
    
    void Update()
    {
        if (isDead) return;
        
        if (Physics2D.OverlapCircle(transform.position, radius, _player.death))
        {
            TriggerDeath();
        }
    }

    private void TriggerDeath()
    {
        isDead = true;
        _player.enabled = false; 
        SceneManager.LoadScene("Start");
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
