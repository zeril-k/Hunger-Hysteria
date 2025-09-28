using UnityEngine;
using UnityEngine.UI;

public class lives : MonoBehaviour
{
    public int Lives = 3;
    public int maxLives = 3;

    public AudioSource audioSource;
    audioManager audioManager;

    public int livesCount;
    public Text livesText;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManager>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Lives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text =livesCount.ToString();
    }

    public void TakeDamage(int amount)
    {
        Lives -= amount;

        if (Lives <= 0)
        {
            Destroy(gameObject);
        }

        if (Lives <= 1)
        { 
            audioManager.PlaySFX(audioManager.heartbeat);
        }
    }
}
