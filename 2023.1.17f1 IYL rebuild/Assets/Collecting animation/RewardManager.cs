using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;

public class RewardManager : MonoBehaviour
{
    [SerializeField] private GameObject PileOfCoinParent;
    [SerializeField] private TextMeshProUGUI Counter;
    [SerializeField] private Vector3[] InitialPos;
    [SerializeField] private Quaternion[] initialRotation;
    [SerializeField] private int CoinNo;
    
    void Start()
    {
        InitialPos = new Vector3[CoinNo];
        initialRotation = new Quaternion[CoinNo];

        for (int i = 0; i < PileOfCoinParent.transform.childCount; i++)
        {
            InitialPos[i] = PileOfCoinParent.transform.GetChild(i).position;
            initialRotation[i] = PileOfCoinParent.transform.GetChild(i).rotation;
        }
    }

    private void Update()
    {
        if (StaticString.animation_)
        {
            RewardPileOfCoins(10);
            StaticString.animation_ = false;

        }
    }
    private void Reset()
    {
        for (int i = 0; i < PileOfCoinParent.transform.childCount; i++)
        {
            PileOfCoinParent.transform.GetChild(i).position = InitialPos[i];
            PileOfCoinParent.transform.GetChild(i).rotation = initialRotation[i];
        }
    }

    public void RewardPileOfCoins(int noCoin)
    { 
        Reset();


        var delay = 0f;

        PileOfCoinParent.SetActive(true);

        for (int i = 0; i < PileOfCoinParent.transform.childCount; i++)
        {
            PileOfCoinParent.transform.GetChild(i).DOScale(1f, 0.3f).SetDelay(delay).SetEase(Ease.OutBack);

            PileOfCoinParent.transform.GetChild(i).GetComponent<RectTransform>().DOAnchorPos(new Vector2(-547f, 1420f), 1f).SetDelay(delay + 0.5f).SetEase(Ease.InBack);

            PileOfCoinParent.transform.GetChild(i).DORotate(Vector3.zero, 0.5f).SetDelay(delay + 0.5f).SetEase(Ease.Flash);

            PileOfCoinParent.transform.GetChild(i).DOScale(0f, 0.3f).SetDelay(delay + 1.8f).SetEase(Ease.OutBack);

            delay += 0.1f;
        }
    }
}

