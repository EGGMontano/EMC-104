using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public GameObject targetObj;
    public float maxSize, defaultSize, animationTime;

    public void IncreaseSize()
    {
        targetObj.transform.DOScale(maxSize, animationTime);
    }

    public void ReturnSize()
    {
        targetObj.transform.DOScale(defaultSize, animationTime);
    }
}
