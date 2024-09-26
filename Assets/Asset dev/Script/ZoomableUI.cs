using UnityEngine;

public class ZoomableUI : MonoBehaviour
{
    public Transform playerCamera; // Reference to the player's camera
    public float zoomDistance = 0.5f; // Distance to zoom in
    public float zoomSpeed = 5f; // Speed of the zoom-in effect

    private Vector3 originalPosition;
    private bool isZoomedIn = false;

    void Start()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (isZoomedIn)
        {
            Vector3 targetPosition = playerCamera.position + playerCamera.forward * zoomDistance;
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * zoomSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, originalPosition, Time.deltaTime * zoomSpeed);
        }
    }

    public void ZoomIn()
    {
        isZoomedIn = true;
    }

    public void ZoomOut()
    {
        isZoomedIn = false;
    }
}
