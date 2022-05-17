using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Card : MonoBehaviour
{
    [SerializeField] CreateCards card;
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(card.motivation <= stats.playerMotivation)
        {
            PlayCard();
        }
    }
    void PlayCard()
    {

    }
}
