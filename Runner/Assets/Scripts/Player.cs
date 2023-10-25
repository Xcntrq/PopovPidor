using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator Animator;
    public int JumpsAvailable;
    public bool IsAlive;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (JumpsAvailable > 0) && IsAlive)
        {
            GetComponent<Rigidbody2D>().velocity = 7 * Vector2.up;
            JumpsAvailable -= 1;
            Animator.SetBool("IsJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JumpsAvailable = 2;
        Animator.SetBool("IsJumping", false);
    }
}