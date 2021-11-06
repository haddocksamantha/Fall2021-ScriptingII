using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class HealthText : MonoBehaviour
{
    [SerializeField] private playerhealthSO healthData;
    private Text numOfLives;

    private void Awake()
    {
        numOfLives = GetComponent<Text>();
    }
    
    private void Update()
    {
        HealthStatus();
    }

    public void HealthStatus()
    {
        numOfLives.text = ("Lives:" + healthData.model.lives);
    }
    
}
