using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Card : MonoBehaviour
{
    [SerializeField] CreateCards card;
    private void OnMouseDown()
    {
        if(card.motivation <= stats.playerMotivation)
        {
            PlayCard();
        }
    }

    void PlayCard()
    {
        stats.playerHappiness += card.happiness;
        stats.playerSleep += card.rest;
        stats.playerFood += card.food;
        stats.playerStress += card.stress;
        Debug.Log(card.food);
    }
}