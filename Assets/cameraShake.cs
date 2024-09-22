using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class cameraShake : MonoBehaviour
{
    static public bool cardFlipped = false;

    void Update()
    {
        Sequence shake = DOTween.Sequence();

        if (cardFlipped == true)
        {
            cardFlipped = false;
            shake.AppendInterval(1f).Append(transform.DOShakePosition(1.2f));
        }
    }
}
