using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : EnemyMnager
{
    public TextMeshPro ArmyNoTxt;
    void Start()
    {
        ArmyNoTxt = transform.GetChild(0).GetComponent<TextMeshPro>();
        ArmyNoTxt.text = ArmyNo.ToString();
        TerritorySprite = transform.parent.GetComponent<SpriteRenderer>();
    }
    public void Next(){
      SceneManager.LoadScene("Menu");
    }
    public void Home(){
      SceneManager.LoadScene("Menu");
    }
    public void Refresh(){
      SceneManager.LoadScene("LearningPage4");
    }
    public void ExitApplication(){
      Application.Quit();
    }
}
