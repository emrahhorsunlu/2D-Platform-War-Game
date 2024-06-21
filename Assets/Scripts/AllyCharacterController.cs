using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AllyCharacterController : MonoBehaviour
{
    public float targetX = 50f;         // Hedef X pozisyonu      // Hareket hızı
    public float moveSpeed;
    private float startX = -5f;
    Troop troop;      // Başlangıç X pozisyonu

    void Start()
    {
        this.transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        troop = this.gameObject.GetComponent<Troop>();
        troop.speed = 5f;
        troop.health = 100f;
        troop.type = 0;
        moveSpeed = troop.speed;
    }

    void Update()
    {
        Debug.Log(troop.health);
        if (troop.health > 100)
        {
            if (this.transform.position.x < targetX)
            {
                Debug.Log("Döngüye girdi");
                // Hareket hızını belirli bir hızda sabit tutarak hareket ettir
                float moveDistance = troop.speed * Time.deltaTime;
                float newX = this.transform.position.x + moveDistance;

                // Hedefe ulaştığında X pozisyonunu hedefe eşitle
                if (newX > targetX)
                {
                    newX = targetX;
                }
                this.transform.position = new Vector3(newX, transform.position.y, transform.position.z);

            }
        }
    }

}
