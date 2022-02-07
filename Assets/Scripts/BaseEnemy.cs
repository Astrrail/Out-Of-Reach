using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy 
{
    public string name;

    public enum Type
    {
        Grass,
        Fire,
        Water,
        Earth
    }
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        SuperRare
    }

    public Type enemyType;
    public Rarity rarity;

    public float baseHitPoints;
    public float currentHitPoints;
    public float baseMana;
    public float currentMana;

    public float baseAtk;
    public float currentAtk;
    public float baseDef;
    public float currentDef;

}
