using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float dragSpeed = 0.1f;       // Sürükleme hızı
    public float smoothTime = 0.3f;      // Yumuşak geçiş zamanı
    public float minX = -10f;            // Minimum X sınırı
    public float maxX = 10f;             // Maximum X sınırı
    public float fixedZ = -10f;          // Sabit Z pozisyonu

    private Vector3 velocity = Vector3.zero;
    private Vector3 targetPosition;
    private Vector3 dragOrigin;

    void Start()
    {
        // Başlangıçta kameranın pozisyonunu sabitle
        targetPosition = transform.position;
        targetPosition.z = fixedZ;  // Z ekseni sabit olarak ayarla
    }

    void Update()
    {
        // Sol mouse tuşuna basıldığında
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
        }

        // Sürükleme işlemi devam ederken
        if (Input.GetMouseButton(0))
        {
            // Mouse hareketini hesapla
            Vector3 currentMousePos = Input.mousePosition;
            Vector3 difference = (currentMousePos - dragOrigin) * dragSpeed;

            // Hedef pozisyonu güncelle (yalnızca X ekseni)
            targetPosition.x += difference.x;

            // X sınırlarını kontrol et
            targetPosition.x = Mathf.Clamp(targetPosition.x, minX, maxX);

            // Mouse'un sürüklendiği başlangıç noktasını güncelle
            dragOrigin = currentMousePos;
        }

        // Yumuşak geçiş yaparak kamerayı hedef pozisyona hareket ettir (yalnızca X ekseni)
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
