using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;
using TMPro;

public class MoneyController : MonoSingleton<MoneyController>
{
    public TextMeshProUGUI moneyText;
    public float money, moneyTimer;

    void Start()
    {
        money = 0;
        moneyText.text = money.ToString();
    }
    void Update()
    {
        if (money >= 0)
        {
            // Zamanlayıcıyı güncelle
            moneyTimer += Time.deltaTime;
            // Her 1 saniyede para miktarını artır
            if (moneyTimer >= 1f)
            {
                money += 2f;
                moneyTimer = 0f; // Zamanlayıcıyı sıfırla
                moneyText.text = money.ToString();
            }
        }
    }
}