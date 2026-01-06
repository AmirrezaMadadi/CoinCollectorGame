using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D character;
    public float jumpHeight;
    public Animator jumpAnimator;
    public Animator deathAnimator;
    public bool isGameOver;
    public GameObject gameOverPanel;
    void Start()
    {
        
    }

    void Update()
    {
        if (isGameOver == false)
        {
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                Jumping();
                jumpAnimator.Play("PlayerJump");
            }   
        }
        else
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Jumping()
    {
        if (isGameOver == false)
        {
            character.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            jumpAnimator.Play("PlayerJump");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            deathAnimator.Play("PlayerDeath");
            isGameOver = true;
        }
    }
}
