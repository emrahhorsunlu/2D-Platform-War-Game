using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AllyCharacterController : MonoBehaviour
{
    public float targetX = 50f;         // Hedef X pozisyonu      // Hareket hızı
    private float startX = -5f;
    public Troop troop;

    void Start()
    {
        transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        troop = GetComponent<Troop>();
    }

    void Update()
    {
        if (transform.position.x < targetX)
        {
            // Hareket hızını belirli bir hızda sabit tutarak hareket ettir
            float moveDistance = troop.speed * Time.deltaTime;
            float newX = transform.position.x + moveDistance;

            // Hedefe ulaştığında X pozisyonunu hedefe eşitle
            if (newX > targetX)
            {
                newX = targetX;
                Destroy(gameObject);
            }
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }

    }

}
