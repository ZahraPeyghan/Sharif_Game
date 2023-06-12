using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager pleyerManagerInstance;
    private int Army_No;
    [SerializeField] private TextMeshPro Army_No_Txt;
    private IEnumerator Ie_fill_army;
    void Start()
    {
        pleyerManagerInstance = this;
        Ie_fill_army = FillTheArmy();
        StartCoroutine(Ie_fill_army);
    }
    private IEnumerator FillTheArmy(){
        int counter = 0;
        Army_No = 0;
        while (counter < 10){
            counter++;
            Army_No_Txt.text = counter.ToString();
            Army_No = counter;
            yield return new WaitForSecondsRealtime(0.5f);
        }
    }
}
