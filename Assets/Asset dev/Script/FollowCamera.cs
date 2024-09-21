using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform cameraTransform;

    void Update()
    {
        // Update posisi Canvas untuk mengikuti kamera
        transform.position = cameraTransform.position + cameraTransform.forward * 2.0f; // 2.0f bisa disesuaikan untuk jarak
        transform.LookAt(cameraTransform);
        transform.Rotate(0, 180, 0); // Agar button menghadap ke pemain
    }
}
