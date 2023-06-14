using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class EnemyMnager : MonoBehaviour
{
    public int ArmyNo , PlayerArmyNo;
    public SpriteRenderer TerritorySprite;
    void Awake(){
        ArmyNo = Random.Range(10 , 25);
    }
    public void UnderAttack(TextMeshPro ArmyNoTxt){
      if(ArmyNo > 0 ){
        ArmyNo --;
        ArmyNoTxt.text = ArmyNo.ToString();
      }
      else{
        PlayerArmyNo ++;
        ArmyNoTxt.text = PlayerArmyNo.ToString();
      }
      if(ArmyNo == 0){
        TerritorySprite.color = new Color(0.38f , 0.73f , 0.82f);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(0.44f , 0.95f , 0.75f);
      }
    }
}
