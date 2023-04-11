using UnityEngine;

public class FollowCapsule : MonoBehaviour
{
    public Transform capsuleTransform;
    public Vector3 offset;

    void Update()
    {
        // Set camera position to capsule position with an offset
        transform.position = capsuleTransform.position + offset;

        // Set camera rotation to be the same as capsule rotation
        transform.rotation = capsuleTransform.rotation;
    }
}
