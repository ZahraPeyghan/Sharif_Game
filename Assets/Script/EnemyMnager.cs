using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyMnager : MonoBehaviour
{
    public int ArmyNo;
    public SpriteRenderer TerritorySprite;
    void Awake(){
        ArmyNo = Random.Range(10 , 25);
    }
}
