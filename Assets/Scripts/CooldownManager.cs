using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using JetBrains.Annotations;

public class CooldownManager : MonoBehaviour
{
    public GameObject gameManager;
    float currentCooldownTime;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }
    public void StartCooldown(TroopDataSO troopDataSO)
    {
        StartCoroutine(ButtonCooldown(troopDataSO));
    }

    private IEnumerator ButtonCooldown(TroopDataSO troopDataSO)
    {

        this.gameObject.GetComponent<Button>().interactable = false;
        this.gameObject.GetComponent<Button>().enabled = false;

        currentCooldownTime = troopDataSO.cooldownTime;
        while (currentCooldownTime > 0)
        {
            this.gameObject.GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text = currentCooldownTime.ToString("F1") + "s";
            currentCooldownTime -= Time.deltaTime;
            yield return null;
        }
        this.gameObject.GetComponent<Button>().interactable = true;
        this.gameObject.GetComponent<Button>().enabled = true;
        this.gameObject.GetComponent<Button>().GetComponentInChildren<TextMeshProUGUI>().text = " ";
    }
}
