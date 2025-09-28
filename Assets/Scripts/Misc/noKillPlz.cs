using UnityEngine;

public class noKillPlz : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
