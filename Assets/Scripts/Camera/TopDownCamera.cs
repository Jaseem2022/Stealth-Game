using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public Transform player;  // Drag your player here
    public Vector3 offset = new Vector3(0, 10, 0); // Camera height above player
    public float smoothSpeed = 0.125f; // Smooth camera movement

    void LateUpdate()
    {
        if (player == null) return;

        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Optional: keep camera looking down
        transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
