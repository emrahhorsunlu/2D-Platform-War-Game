using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyCharacterController : MonoBehaviour
{
    public float targetX = 50f;         // Hedef X pozisyonu
    public float moveSpeed = 2f;        // Hareket hızı

    private float startX = -5f;         // Başlangıç X pozisyonu

    void Start()
    {
        transform.position = new Vector3(startX, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // Hedefe ulaşıncaya kadar hareket et
        if (transform.position.x < targetX)
        {
            // Hareket hızını belirli bir hızda sabit tutarak hareket ettir
            float moveDistance = moveSpeed * Time.deltaTime;
            float newX = transform.position.x + moveDistance;

            // Hedefe ulaştığında X pozisyonunu hedefe eşitle
            if (newX > targetX)
                newX = targetX;

            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }

}
