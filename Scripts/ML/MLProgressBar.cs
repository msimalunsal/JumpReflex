using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class MLProgressBar : MonoBehaviour
{
    private int score = 0;
    private Image progressFillImage;
    private void Start()
    {
        progressFillImage =GetComponent<Image>();
    }
    private void OnEnable()
    {
        EventManager.OnMLReward.AddListener(UpdateProgressBar);
    }

    private void OnDisable()
    {
        EventManager.OnMLReward.RemoveListener(UpdateProgressBar);
    }

    private void UpdateProgressBar()
    {
        score++;
        if (score == 8)
        {
            EventManager.OnLevelFail.Invoke();
        }
        float val = (float)score / 15;
        progressFillImage.DOFillAmount(val, .8f);
    }
}
