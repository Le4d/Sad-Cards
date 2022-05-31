using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> deck = new List<GameObject>();
    [SerializeField] Transform[] cardSlots;
    [SerializeField] bool[] availableCardSlots;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    GameObject randCard = deck[Random.Range(0, deck.Count)];
                    Instantiate(randCard.gameObject, cardSlots[i].position, Quaternion.identity);
                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                }
            }
        }
    }

    public void Start()
    {
        DrawCard();
    }
}