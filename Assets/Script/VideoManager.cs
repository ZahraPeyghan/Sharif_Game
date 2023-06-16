using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour
{
    public GameObject NextButton;
    public void LoadNextStep(){
      SceneManager.LoadScene("LearningPage2");
   }
      public void LoadNextStep1(){
      SceneManager.LoadScene("LearningPage3");
   }
       public void LoadNextStep2(){
      SceneManager.LoadScene("LearningPage4");
   }
}
