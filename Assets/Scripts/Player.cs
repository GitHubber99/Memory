using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private LayerMask selectableCardMask;
    private RaycastHit hitInfo;

    public void SelectCard()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if(Physics.Raycast(ray, out hitInfo, selectableCardMask))
        {
            
        }
    }

    public void FlipCard(Card card)
    {
        card.tweenRot.from = transform.position;
        card.tweenRot.to = new Vector3(transform.position.x, rotChangePoint * 2, transform.position.z);
        card.tweenRot.PlayForward();
        card.ChangeFace();
    }

    public void MoveCard (Card card, Vector3 to)
    {
        card.tweenPos.from = card.gameObject.transform.position;
        card.tweenPos.to = to;
        card.tweenPos.PlayForward();
    }

}
