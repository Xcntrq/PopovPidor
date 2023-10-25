using UnityEngine;

public class Background : MonoBehaviour
{
    public float Speed;

    private void Update()
    {
        transform.Translate(Speed * Time.deltaTime * Vector2.left);

        if (transform.position.x < -20)
        {
            transform.Translate(40 * Vector2.right);
        }
    }
}