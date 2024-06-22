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
    public void StartCooldown()
    {
        StartCoroutine(ButtonCooldown());
    }

    private IEnumerator ButtonCooldown()
    {
        if (this.gameObject.name == "Card1")
            currentCooldownTime = 5f;
        else if (this.gameObject.name == "Card2")
            currentCooldownTime = 7f;
        else if (this.gameObject.name == "Card3")
            currentCooldownTime = 10f;

        gameManager.GetComponent<CardController>().OnCardButtonClicked(this.gameObject.name);
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
