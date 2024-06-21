using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CooldownManager : MonoBehaviour
{
    public GameObject gameManager;
    public void StartCooldown()
    {
        gameManager = GameObject.Find("GameManager");
        StartCoroutine(ButtonCooldown());
    }

    private IEnumerator ButtonCooldown()
    {
        Debug.Log(this.gameObject.name);
        gameManager.GetComponent<CardController>().OnCardButtonClicked(this.gameObject.name);
        float currentCooldownTime = 10f; // Cooldown süresi
        this.gameObject.GetComponent<Button>().interactable = false;
        this.gameObject.GetComponent<Button>().enabled = false;

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
