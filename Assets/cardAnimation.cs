using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class cardAnimation : MonoBehaviour
{
    private float sizeX = 0.508f, sizeZ = 0.381f;
    void OnMouseOver()
    {
        Sequence cardSequence = DOTween.Sequence();

        Debug.Log("THE MOUSE IS OVER ME!!!");
        cardSequence.Append(transform.DOScale(new Vector3((sizeX * 1.5f), 1f, (sizeZ * 1.5f)), 0.4f));

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("OH GOD IT CLICKED");
            cardSequence.Append(transform.DOScale(new Vector3((sizeX * 2f), 1f, (sizeZ * 2f)), 0.5f));
            cardSequence.Join(transform.DORotate(new Vector3(90, 900, 0), 1f, RotateMode.FastBeyond360).SetEase(Ease.OutSine));
            cardSequence.Append(transform.DOScale(new Vector3((sizeX * 1.5f), 1f, (sizeZ * 1.5f)), 0.4f));
            cameraShake.cardFlipped = true;
        }
    }   
    void OnMouseExit()
    {
        transform.DOScale(new Vector3(sizeX, 1f, sizeZ), 0.4f);
    }
}