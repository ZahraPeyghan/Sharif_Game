using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class EnemyMnager : MonoBehaviour
{
    public int ArmyNo , PlayerArmyNo;
    public SpriteRenderer TerritorySprite;
    public GameObject Tranation1;
    public GameObject Tranation2;
    public EndEnemy endenemy;
    public GameObject WinPanel;
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
        if(endenemy.EndEnemy1 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation1());
        }
        if(endenemy.EndEnemy2 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation2());
        }
        if(endenemy.EndEnemy3 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation3());
        }
        if(endenemy.EndEnemy4 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation4());
        }
        if(endenemy.EndEnemy5 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation5());
        }
        if(endenemy.EndEnemy6 == true){
        Tranation1.SetActive(true);
        Tranation2.SetActive(true);
        StartCoroutine(TimeTranslation6());
        }
      }
    }
    IEnumerator TimeTranslation1(){
      while(endenemy.EndEnemy1){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        SceneManager.LoadScene("Story1Page");
        }
    }
    IEnumerator TimeTranslation2(){
      while(endenemy.EndEnemy2){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        SceneManager.LoadScene("Story2Page");
        }
    }
    IEnumerator TimeTranslation3(){
      while(endenemy.EndEnemy3){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        SceneManager.LoadScene("Story3Page");
        }
    }
    IEnumerator TimeTranslation4(){
      while(endenemy.EndEnemy4){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        WinPanel.SetActive(true);
        }
    }
    IEnumerator TimeTranslation5(){
      while(endenemy.EndEnemy5){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        SceneManager.LoadScene("Play2");
        }
    }
    IEnumerator TimeTranslation6(){
      while(endenemy.EndEnemy5){
        yield return new WaitForSeconds(1.3f);
        Tranation1.SetActive(false);
        Tranation2.SetActive(false);
        SceneManager.LoadScene("PlayGame");
        }
    }
}
