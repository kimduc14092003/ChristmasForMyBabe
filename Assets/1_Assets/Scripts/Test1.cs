using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public Transform movePoint;
    public float time;
    private void Start()
    {
        transform.DOMove(movePoint.position,time).SetLoops(-1,LoopType.Yoyo);
    }
}
