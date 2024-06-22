using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troop : MonoBehaviour
{
    public GameObject character;
    public Type type { get; set; }
    public float speed { get; set; }
    public float damage { get; set; }
    public float armor { get; set; }
    public float health { get; set; }
    public int price { get; set; }
}
public enum Type
{
    warrior,
    archer,
    cavalry
}
