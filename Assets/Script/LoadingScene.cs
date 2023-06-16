using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class LoadingScene : MonoBehaviour
{
   float time , second, LoadingValue ;
   int LoadingTime;
   public Image FillImage;
   public Text LoadingText;
   void Start(){
      second=5;
      Invoke("LoadGame",5f);
   }
   void Update(){
      if(time<5){
         time += Time.deltaTime;
        LoadingValue = FillImage.fillAmount = time/second;
        LoadingTime = (int)(LoadingValue * 100f);
        LoadingText.text = "% " + LoadingTime;
      }
   }
   public void LoadGame(){
      SceneManager.LoadScene("LearningPage1");
   }
}
