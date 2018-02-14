using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSc : MonoBehaviour
{

    public enum UNITTRIBE
    {
        NEUTRAL = 0,
        PROTOSS,
        ZERG,
        TERRAN
    }
    public UNITTRIBE unitTribe;
    public string unitName;
    public int Hp;
    public int Mp;
    public int Atk;
    public int Def;
    public int Shd;
    public float unitAsp;
    public float unitMsp;
    public float unitRange;

    void Start()
    {
        gameObject.name = unitName;
    }

}
