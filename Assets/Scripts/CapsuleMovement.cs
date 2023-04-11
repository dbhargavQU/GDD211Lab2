using UnityEngine;
using UnityEngine.UI;

public class CapsuleMovement : MonoBehaviour
{
    public Slider forwardBackwardSlider;
    public Slider leftRightSlider;
    public float minSpeed = 1f;
    public float maxSpeed = 10f;
    public GameObject enemyPrefab;


    private void Update()
    {
        // Calculate forward/backward speed based on slider value
        float forwardBackwardValue = forwardBackwardSlider.value;
        float forwardBackwardSpeed = 0f;

        if (forwardBackwardValue < 5f)
        {
            forwardBackwardSpeed = Mathf.Lerp(-minSpeed, -maxSpeed, forwardBackwardValue / 5f);
        }
        else if (forwardBackwardValue > 5f)
        {
            forwardBackwardSpeed = Mathf.Lerp(minSpeed, maxSpeed, (forwardBackwardValue - 5f) / 5f);
        }

        // Calculate left/right speed based on slider value
        float leftRightValue = leftRightSlider.value;
        float leftRightSpeed = 0f;

        if (leftRightValue < 5f)
        {
            leftRightSpeed = Mathf.Lerp(-minSpeed, -maxSpeed, leftRightValue / 5f);
        }
        else if (leftRightValue > 5f)
        {
            leftRightSpeed = Mathf.Lerp(minSpeed, maxSpeed, (leftRightValue - 5f) / 5f);
        }

        // Combine the speeds into a move direction vector
        Vector3 moveDirection = new Vector3(leftRightSpeed, 0f, forwardBackwardSpeed);
        transform.Translate(moveDirection * Time.deltaTime);

        // Detect collision with enemy prefab
        Collider[] hitColliders = Physics.OverlapBox(transform.position, new Vector3(1f, 1f, 1f), Quaternion.identity);

        foreach (Collider collider in hitColliders)
        {
            if (collider.gameObject.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
        }


}


}
