using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsUpdate : MonoBehaviour
{
    [SerializeField]  TextMeshProUGUI motivation;
    [SerializeField]  TextMeshProUGUI happiness;
    [SerializeField]  TextMeshProUGUI stress;
    [SerializeField]  TextMeshProUGUI rest;
    [SerializeField]  TextMeshProUGUI food;
    [SerializeField]  TextMeshProUGUI day;

    private void Update()
    {
        motivation.text =  stats.playerMotivation.ToString();
        happiness.text = "Happines: " + stats.playerHappiness + "/10".ToString();
        stress.text =   "Stress: " + stats.playerStress + "/10".ToString();
        rest.text =  "Sleep: " + stats.playerSleep + "/10".ToString();
        food.text =  "Food: " + stats.playerFood + "/10".ToString();
        day.text =  "day " + stats.day.ToString();
        
    }
}
