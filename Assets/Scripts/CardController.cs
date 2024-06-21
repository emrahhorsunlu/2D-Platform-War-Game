using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class CardController : MonoBehaviour
{

    public GameObject warrior, archer, cavalry;
    public Button card1Btn, card2Btn, card3Btn;
    public float cooldownTime = 10f;  // Bekleme süresi (10 saniye)
    private float currentCooldownTime; // Mevcut kalan süre

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("StageArmy", "Bronze");
        card1Btn = GameObject.Find("Card1").GetComponent<Button>();
        card2Btn = GameObject.Find("Card2").GetComponent<Button>();
        card3Btn = GameObject.Find("Card3").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCardButtonClicked(string buttonName)
    {

        if (PlayerPrefs.GetString("StageArmy") == "Bronze")
        {

            if (buttonName == "Card1" && card1Btn.interactable == true)
            {
                //Debug.Log(buttonName + " button clicked! " + PlayerPrefs.GetString("StageArmy"));
                SpawnCapsule(buttonName);
                StartCoroutine(ButtonCooldown(card1Btn));
            }
            else if (buttonName == "Card2" && card2Btn.interactable == true)
            {
                //Debug.Log(buttonName + " button clicked! " + PlayerPrefs.GetString("StageArmy"));
                SpawnCapsule(buttonName);
                StartCoroutine(ButtonCooldown(card2Btn));
            }
            else if (buttonName == "Card3" && card3Btn.interactable == true)
            {
                //Debug.Log(buttonName + " button clicked! " + PlayerPrefs.GetString("StageArmy"));
                SpawnCapsule(buttonName);
                StartCoroutine(ButtonCooldown(card3Btn));
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

    IEnumerator ButtonCooldown(Button myButton)
    {
        if (myButton.interactable)
        {
            Debug.Log("Tıklanan Buton Adı: " + myButton.gameObject.name);
            // Butonu devre dışı bırak
            myButton.interactable = false;
            myButton.enabled = false;
            currentCooldownTime = cooldownTime;

            // Kalan süreyi göster
            while (currentCooldownTime > 0)
            {
                // Kalan süreyi TextMeshPro labeline yazdır
                myButton.GetComponentInChildren<TextMeshProUGUI>().text = currentCooldownTime.ToString("F1") + "s";
                currentCooldownTime -= Time.deltaTime;
                yield return null; // Bir sonraki frame'e kadar bekle
            }

            // Süre doldu, butonu tekrar aktif hale getir ve labeli sıfırla
            myButton.interactable = true;
            myButton.enabled = true;
            myButton.GetComponentInChildren<TextMeshProUGUI>().text = " ";
        }

    }
}
