using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFlow : MonoBehaviour
{  
     public GameObject Background;
     public GameObject ShopButton;
     public GameObject PlayButton;
     public GameObject MapButton;
     public GameObject SettingButton;
     public GameObject NextButton;
     public GameObject BackButton;
     public GameObject SettingPanel;
     public GameObject LevelTxt;
     public GameObject LevelTxt1;
     public GameObject EctorText;
     public GameObject WelcomLern;
     public GameObject SettingLern;
     public GameObject EctonLern;
     public GameObject NextLern;
     public GameObject BackLern;
     public void NextBtn(){
      AudioManager.Instance.PlaySFX("Robot1");
      BackLern.SetActive(true);
      transform.position = new Vector3(Background.transform.position.x+3,transform.position.y,transform.position.z);
      ShopButton.SetActive(true);
      MapButton.SetActive(true);
      PlayButton.SetActive(false);
      SettingButton.SetActive(false);
      NextButton.SetActive(false);
      BackButton.SetActive(true);
      LevelTxt.SetActive(false);
      LevelTxt1.SetActive(false);
      EctorText.SetActive(false);
   }
      public void BackBtn(){
      AudioManager.Instance.PlaySFX("Robot2");
      transform.position = new Vector3(Background.transform.position.x-3,transform.position.y,transform.position.z);
      ShopButton.SetActive(false);
      MapButton.SetActive(false);
      PlayButton.SetActive(true);
      SettingButton.SetActive(true);
      NextButton.SetActive(true);
      BackButton.SetActive(false);
      LevelTxt.SetActive(true);
      LevelTxt1.SetActive(true);
      EctorText.SetActive(true);
   }
   public void ShopBtn(){
      SceneManager.LoadScene("ShopPage");
   }
   public void PlayBtn(){
      SceneManager.LoadScene("LoadingPage");
   }
   public void MapBtn(){
      SceneManager.LoadScene("MapPage");
   }
   public void SettingBtn(){
      SettingPanel.SetActive(true);
   }
   public void WelcomPageLern(){
      WelcomLern.SetActive(false);
      NextLern.SetActive(true);
   }
   public void NextPageLern(){
      NextLern.SetActive(false);
      SettingLern.SetActive(true);
   }
   public void SettingPageLern(){
      SettingLern.SetActive(false);
      EctonLern.SetActive(true);
   }
   public void EctonPageLern(){
      EctonLern.SetActive(false);
   }
   public void BackPageLern(){
      BackLern.SetActive(false);
   }
}
