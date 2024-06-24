using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Button button;
    public TroopDataSO troopDataSO;
    public CardController cardController;

    void Start()
    {
        cardController = CardController.Instance;
        text.text = troopDataSO.price.ToString();
    }

    public void OnCardButtonClicked2()
    {
        if (cardController.money >= troopDataSO.price)
        {
            cardController.money = cardController.money - troopDataSO.price;
            cardController.moneyText.text = cardController.money.ToString();
            SpawnCapsule();
            StartCoroutine(ButtonCooldown());
        }
    }
    void SpawnCapsule()
    {
        Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
        Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

        AllyCharacterController capsule = Instantiate(troopDataSO.characterControllerPrefab, spawnPosition, spawnRotation);
        capsule.troopDataSO = Instantiate(troopDataSO);
    }

    private IEnumerator ButtonCooldown()
    {
        float currentCooldownTime;
        button.interactable = false;
        button.enabled = false;

        currentCooldownTime = troopDataSO.cooldownTime;
        while (currentCooldownTime > 0)
        {
            text.text = currentCooldownTime.ToString("F1") + "s";
            currentCooldownTime -= Time.deltaTime;
            yield return null;
        }
        button.interactable = true;
        button.enabled = true;
        text.text = troopDataSO.price.ToString();
    }
}
