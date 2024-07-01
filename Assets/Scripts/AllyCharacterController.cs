using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class AllyCharacterController : MonoBehaviour
{
    private float targetX = 20f; // Test için 20 yaptım normalde 50 olacak unutma
    private float startX = -5f;
    public TroopDataSO troopDataSO;

    void Start()
    {
        transform.position = new Vector3(startX, transform.position.y, transform.position.z);
        Debug.Log("STARTED HP: " + troopDataSO.health);
    }

    void Update()
    {
        if (troopDataSO.health > 0)
            OnWalk();
    }
    public void OnWalk()
    {
        if (transform.position.x < targetX)
        {
            float moveDistance = troopDataSO.speed * Time.deltaTime;
            float newX = transform.position.x + moveDistance;

            // Hedefe ulaştığında X pozisyonunu hedefe eşitle
            if (newX > targetX)
            {
                newX = targetX;
                troopDataSO.health = 0;
                Debug.Log("NEW HP: " + troopDataSO.health);
                //Destroy(gameObject);
            }
            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        }
    }

}
