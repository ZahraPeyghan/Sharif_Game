using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour
{
   float time , second;
   public Image FillImage;
   void Start(){
      second=5;
      Invoke("LoadGame",5f);
   }
   void Update(){
      if(time<5){
         time += Time.deltaTime;
         FillImage.fillAmount = time/second;
      }
   }
   public void LoadGame(){
      SceneManager.LoadScene("LearningPage");
   }
}
