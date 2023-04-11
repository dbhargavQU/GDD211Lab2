using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public GameObject youWinText;

     private void Start()
    {
        youWinText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            youWinText.SetActive(true);
        }
    }
}
