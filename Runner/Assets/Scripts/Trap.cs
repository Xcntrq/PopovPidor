using UnityEngine;

public class Trap : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 10);
    }

    private void Update()
    {
        transform.Translate(3 * Time.deltaTime * Vector2.left);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Animator>().SetBool("IsDead", true);
        collision.GetComponent<Player>().IsAlive = false;
        Time.timeScale = 0;
    }
}