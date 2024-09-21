using UnityEngine;
using UnityEngine.UI;

public class CaptureTextToSprite : MonoBehaviour
{
    public Camera textCamera;       // Kamera yang akan menangkap teks
    public RenderTexture renderTexture;
    public Image displayImage;      // Image UI untuk menampilkan sprite

    void Start()
    {
        CaptureAndConvertToSprite();
    }

    void CaptureAndConvertToSprite()
    {
        // Render kamera ke RenderTexture
        RenderTexture.active = renderTexture;
        textCamera.Render();

        // Membuat Texture2D dari RenderTexture
        Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
        texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();

        // Buat sprite dari Texture2D
        Sprite textSprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        // Tampilkan sprite ke UI Image
        displayImage.sprite = textSprite;

        // Jangan lupa reset RenderTexture.active
        RenderTexture.active = null;
    }
}
