using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip ambience;
    public AudioClip bubbles;
    public AudioClip crunch;
    public AudioClip alarm;
    public AudioClip steps;
    public AudioClip growl;
    public AudioClip gulp;
    public AudioClip heartbeat;
    public AudioClip scream;
    public AudioClip metal;

    public AudioClip mainMenu;
    public AudioClip containmentZone;
    public AudioClip labs;
    public AudioClip escape;
    public AudioClip bitcrunch;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        musicSource.clip = containmentZone;
        musicSource.Play();
    }

void Update()
{
    Scene currentScene = SceneManager.GetActiveScene();

    if (currentScene.name == "Death Screen")
    {
        // Stops playing music in level 1 scene
        Destroy(gameObject);
    }
}

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
