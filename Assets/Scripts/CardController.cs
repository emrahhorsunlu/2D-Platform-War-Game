using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class CardController : MonoBehaviour
{
    public GameObject warrior, archer, cavalry;
    public Button card1Btn, card2Btn, card3Btn;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("StageArmy", "Bronze");
        card1Btn = GameObject.Find("Card1").GetComponent<Button>();
        card2Btn = GameObject.Find("Card2").GetComponent<Button>();
        card3Btn = GameObject.Find("Card3").GetComponent<Button>();
    }

    public void OnCardButtonClicked(string buttonName)
    {
        SpawnCapsule(buttonName);
    }

    void SpawnCapsule(string CardName)
    {
        if (CardName == "Card1")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(warrior, spawnPosition, spawnRotation);
            Troop troop = capsule.GetComponent<Troop>();
            troop.type = Type.warrior;
            troop.speed = 0.5f;
            troop.damage = 50f;
            troop.armor = 5f;
            troop.health = 100f;
            troop.price = 20;
            troop.character = capsule;
        }
        else if (CardName == "Card2")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(archer, spawnPosition, spawnRotation);
            Troop troop = capsule.GetComponent<Troop>();
            troop.type = Type.archer;
            troop.speed = 0.7f;
            troop.damage = 75f;
            troop.armor = 2f;
            troop.health = 100f;
            troop.price = 50;
            troop.character = capsule;
        }
        else if (CardName == "Card3")
        {
            Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
            Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

            GameObject capsule = Instantiate(cavalry, spawnPosition, spawnRotation);
            capsule.GetComponent<Troop>().type = Type.cavalry;
            Troop troop = capsule.GetComponent<Troop>();
            troop.type = Type.cavalry;
            troop.speed = 1f;
            troop.damage = 100f;
            troop.armor = 15f;
            troop.health = 100f;
            troop.price = 100;
            troop.character = capsule;
        }

    }


}
