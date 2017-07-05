using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public static float rotChangePoint = 90;
    private static string[] frontsNames = { "Silvio0", "Silvio1", "Silvio2", "Silvio3", "Silvio4", "Silvio5", "Silvio6", "Silvio7", "Silvio8", "Silvio9", "Silvio10", "Silvio11", "Silvio12", "Silvio13", "Silvio14", "Silvio15", "Silvio16", "Silvio17", "Silvio18", "Silvio19" };

    private string front;
    public string back;

    public static Dictionary<GameObject, Card> cards = new Dictionary<GameObject, Card>();

    public UISprite cardSprite;

    public TweenRotation tweenRot;
    public TweenPosition tweenPos;

    private void AddMe()
    {
        cards.Add(gameObject, this);
    }

    public void ChangeFace()
    {
        while (gameObject.transform.rotation.eulerAngles.y < rotChangePoint)
        {
            return;
        }
        if (cardSprite.spriteName == front)
            cardSprite.spriteName = back;
        else if (cardSprite.spriteName == back)
            cardSprite.spriteName = front;
    }

}
