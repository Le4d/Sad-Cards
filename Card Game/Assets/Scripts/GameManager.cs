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
            GameObject randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    Instantiate(randCard.gameObject, cardSlots[i].position, Quaternion.identity);
                    randCard.gameObject.SetActive(true);
                    randCard.transform.position = cardSlots[i].position;
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