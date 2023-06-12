using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : EnemyMnager
{
    public TextMeshPro ArmyNoTxt;
    void Start()
    {
        ArmyNoTxt = transform.GetChild(0).GetComponent<TextMeshPro>();
        ArmyNoTxt.text = ArmyNo.ToString();
    }
}
