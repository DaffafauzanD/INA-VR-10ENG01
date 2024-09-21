using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform targetPosition; // Posisi tujuan (Posisi 2)
    public float speed = 5f;         // Kecepatan perpindahan

    private bool shouldMove = false;

    // Method ini akan dipanggil ketika tombol diklik
    public void OnButtonClick()
    {
        shouldMove = true;
    }

    void Update()
    {
        if (shouldMove)
        {
            // Pindahkan objek menuju posisi tujuan
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);

            // Hentikan perpindahan jika sudah mencapai posisi tujuan
            if (transform.position == targetPosition.position)
            {
                shouldMove = false;
            }
        }
    }
}
