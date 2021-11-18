using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class PenaltyText : MonoBehaviour
{
    [SerializeField] private PenaltySO pSO;
    private Text penaltyPrint;
    
    void Start()
    {
        pSO.penaltyOn = false;
        penaltyPrint = GetComponent<Text>();
    }
    
    void Update()
    {
        if (pSO.penaltyOn)
        {
            StartCoroutine(ShowPenaltyText("-" + pSO.penalty, 13.5f ));
        }
        else
        {
            penaltyPrint.gameObject.SetActive(false);
        }
    }

    IEnumerator ShowPenaltyText(string num, float time)
    {
        penaltyPrint.text = num;
        penaltyPrint.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        pSO.penaltyOn = false;
        penaltyPrint.gameObject.SetActive(false);

    }
    
    
}
