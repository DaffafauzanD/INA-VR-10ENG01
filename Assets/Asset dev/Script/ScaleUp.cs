using UnityEngine;

public class ScaleUp : MonoBehaviour
{
    public float scaleSpeed = 1f; // Kecepatan transisi
    public Vector3 targetScale = new Vector3(1f, 1f, 1f); // Skala akhir
    public float timeToHide = 5f; // Waktu dalam detik sebelum objek disembunyikan

    private float timeElapsed = 0f; // Waktu yang telah berlalu

    void Start()
    {
        // Set initial scale to zero
        transform.localScale = Vector3.zero;
    }

    void Update()
    {
        // Smoothly interpolate the scale from zero to target scale
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * scaleSpeed);

        // Update time elapsed
        timeElapsed += Time.deltaTime;

        // Check if the elapsed time exceeds the time to hide the object
        if (timeElapsed >= timeToHide)
        {
            // Hide the object by deactivating it
            gameObject.SetActive(false);
        }
    }
}
