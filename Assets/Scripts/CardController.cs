using UnityEngine.UI;
using UnityEngine;
using Unity.VisualScripting;

public class CardController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("StageArmy", "Bronze");
    }

    public void OnCardButtonClicked2(TroopDataSO troopDataSO)
    {
        SpawnCapsule(troopDataSO);
    }

    void SpawnCapsule(TroopDataSO troopDataSO)
    {
        Vector3 spawnPosition = new Vector3(-5f, -1.85f, 0f);
        Quaternion spawnRotation = Quaternion.identity;   // Rotasyon olmadan başlangıç rotasyonu

        AllyCharacterController capsule = Instantiate(troopDataSO.characterControllerPrefab, spawnPosition, spawnRotation);
        capsule.troopDataSO = Instantiate(troopDataSO);
    }
}