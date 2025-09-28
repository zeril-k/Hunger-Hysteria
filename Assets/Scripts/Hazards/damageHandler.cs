using UnityEngine;

public class damageHandler : MonoBehaviour
{
    public lives lives;
    public int damage = 1;

    private checkpointSaver checkpointSaver;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        checkpointSaver = GameObject.FindGameObjectWithTag("Player").GetComponent<checkpointSaver>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            lives.TakeDamage(damage);

            checkpointSaver.warpPlayerToSafeGround();
        }
    }
}
