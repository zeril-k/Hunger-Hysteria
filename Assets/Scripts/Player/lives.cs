using UnityEngine;

public class lives : MonoBehaviour
{
    public int Lives;
    public int maxLives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        Lives -= amount;

        if (Lives <= 0)
        {
            Destroy(gameObject);
        }
    }
}
