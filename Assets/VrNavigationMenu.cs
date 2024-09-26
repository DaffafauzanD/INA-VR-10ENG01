using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VrNavigationMenu : MonoBehaviour
{
    public GameObject navMenu;  // Objek menu navigasi
    public Transform vrCamera;
    public float distance = 2.0f;  // Jarak menu dari user
    public float verticalOffset = -0.5f;
    public InputActionProperty toggleInput; // Tombol yang digunakan untuk menampilkan/menyembunyikan

    private bool isVisible = false;

    void Update()
    {
        // Cek input tombol Y (atau sesuaikan dengan Input Action yang telah kamu set)
        if (toggleInput.action.triggered)
        {
            isVisible = !isVisible;
            navMenu.SetActive(isVisible);  // Tampilkan atau sembunyikan menu

            // **Selalu perbarui posisi dan rotasi setiap kali menu ditampilkan kembali**
            if (isVisible)
            {
                UpdateMenuPosition();
            }
        }

        // **Pastikan posisi di-update setiap frame saat visible**
        if (isVisible)
        {
            UpdateMenuPosition();
        }
    }

    private void UpdateMenuPosition()
    {
        // Posisi menu di depan VR Camera, hanya rotasi horizontal
        Vector3 lookDirection = new Vector3(vrCamera.forward.x, 0, vrCamera.forward.z);
        lookDirection.Normalize(); // Normalisasi agar mendapatkan arah yang benar
        navMenu.transform.position = vrCamera.position + lookDirection * distance;

        // Update vertical position
        Vector3 newPosition = navMenu.transform.position;
        newPosition.y += verticalOffset;
        navMenu.transform.position = newPosition;

        // Rotasi mengikuti arah horizontal, kunci sumbu X dan Z
        navMenu.transform.rotation = Quaternion.LookRotation(lookDirection);

        // Membalik arah menu jika perlu
        navMenu.transform.Rotate(160, 180, 180);
    }
}
