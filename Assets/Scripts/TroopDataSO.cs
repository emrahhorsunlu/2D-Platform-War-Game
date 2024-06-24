using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card")]

public class TroopDataSO : ScriptableObject
{
    public AllyCharacterController characterControllerPrefab;
    public Type type;
    public float speed;
    public float damage;
    public float armor;
    public float health;
    public int price;
    public float cooldownTime;
    public TroopDataSO nextTroopData;

}
public enum Type
{
    warrior,
    archer,
    cavalry
}