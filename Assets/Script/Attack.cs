using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class Attack : MonoBehaviour
{
   public float soldierDis , directionScale;
   private Vector3 _targetPos, _finalPos , _distance;
   private bool SpreadCompleted;
   private void Update(){
       var offsetFinalTarget = Vector3.Distance(_finalPos , transform.position);
       var offsetTarget = Vector3.Distance(_targetPos , transform.position);
       if(offsetTarget > 0.3f && !SpreadCompleted){
          transform.position = Vector3.MoveTowards(transform.position, _targetPos , Time.deltaTime * 2f);
       }
       else{
        SpreadCompleted = true;
        if(offsetFinalTarget > 1.5f){
            for(int i =0; i< PlayerManager.pleyerManagerInstance.group.Count; i++){
                _distance = transform.position - PlayerManager.pleyerManagerInstance.@group.ElementAt(i).transform.position;
                transform.position = Vector3.MoveTowards(transform.position, _finalPos + _distance * soldierDis,Time.deltaTime * 3f);
            }
        }
        else{
            transform.position = Vector3.MoveTowards(transform.position, _finalPos , Time.deltaTime * 1.5f);
        }
    }
       
   }
   public void ExecuteOrder(Vector3 target ,float angle){
       var direction = Quaternion.Euler(0f , 0f, angle) * (target - transform.position);
       _finalPos = target;
       var sqrMg = target - transform. position;
       directionScale = sqrMg.sqrMagnitude >= 30f ? 0.15f : 0.3f;
       _targetPos = transform.position + direction * directionScale;
   }
}
