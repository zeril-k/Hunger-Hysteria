using UnityEngine;
using UnityEngine.UI;

public class humanManager : MonoBehaviour
{
    public int pointsCount = 0;
    public Text pointsText;

    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        pointsText.text = pointsCount.ToString();
    }
}
