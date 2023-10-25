using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float Timer;
    public Transform Prefab;

    private void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer < 0)
        {
            Timer = 3;
            Instantiate(Prefab, transform);
        }
    }
}