using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public GameObject capsule;
    public GameObject gameOverText;

    private void Start()
    {
        gameOverText.SetActive(false);
    }

    private void Update()
    {
        if (!capsule)
        {
            gameOverText.SetActive(true);
        }
    }
}
