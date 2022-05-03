using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle : MonoBehaviour
{
    [SerializeField] private CreateCards[] cards = new CreateCards[5];

    private void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            CreateCards temp = cards[i];

            int replaceNumber = Random.Range(0, cards.Length);

            cards[i] = cards[replaceNumber];

            cards[replaceNumber] = temp;
        }
    }
}