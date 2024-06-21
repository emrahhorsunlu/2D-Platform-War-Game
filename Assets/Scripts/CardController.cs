using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public GameObject warrior, archer, cavalry;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("StageArmy", "Bronze");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCardButtonClicked(string buttonName)
    {
        if (PlayerPrefs.GetString("StageArmy") == "Bronze")
        {
            if (buttonName == "Card1")
            {
                Debug.Log(buttonName + " button clicked!" + "Bronz Çağ");
                SpawnCapsule(buttonName);
            }
            else if (buttonName == "Card2")
            {
                Debug.Log(buttonName + " button clicked!" + "Bronz Çağ");
                SpawnCapsule(buttonName);
            }
            else if (buttonName == "Card3")
            {
                Debug.Log(buttonName + " button clicked!" + "Bronz Çağ");
                SpawnCapsule(buttonName);
            }

        }
    }

    void SpawnCapsule(string CardName)
    {
        if (CardName == "Card1")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(warrior, spawnPosition, spawnRotation);
        }
        else if (CardName == "Card2")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(archer, spawnPosition, spawnRotation);
        }
        else if (CardName == "Card3")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(cavalry, spawnPosition, spawnRotation);
        }

    }
}
