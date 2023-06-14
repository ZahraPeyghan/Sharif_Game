using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Attack
{
     private void OnTriggerEnter(Collider other){
        if(other.CompareTag("enemy") && other.gameObject.name == PlayerManager.pleyerManagerInstance.enemy.name){
            other.GetComponent<Enemy>().UnderAttack(other.GetComponent<Enemy>().ArmyNoTxt);
            gameObject.SetActive(false);
        }
     }
}
