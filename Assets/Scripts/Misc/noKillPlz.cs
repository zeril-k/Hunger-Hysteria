using UnityEngine;
using UnityEngine.UI;

public class noKillPlz : MonoBehaviour
{
    public int pointsTotal = 0;
    public Text totalPointsText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        totalPointsText.text = pointsTotal.ToString();
    }
}
