using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : EnemyMnager
{
    public TextMeshPro ArmyNoTxt;
    public GameObject Tranation1;
    public GameObject Tranation2;
    public GameObject WinPanel;
    void Start()
    {
        ArmyNoTxt = transform.GetChild(0).GetComponent<TextMeshPro>();
        ArmyNoTxt.text = ArmyNo.ToString();
        TerritorySprite = transform.parent.GetComponent<SpriteRenderer>();
    }
    public void Step2(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("Story2Page");
   }
    public void Step1(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("Story1Page");
   }
    public void Step3(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("Story3Page");
   }
    public void EndLearn(){
      WinPanel.SetActive(true);
   }
    public void Home(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("Menu");
    }
   public void Refresh(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("LearningPage4");
    }
   public void Next(){
      Tranation1.SetActive(true);
      Tranation2.SetActive(true);
      SceneManager.LoadScene("Menu");
    }
}
