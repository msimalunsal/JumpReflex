using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class PlayerProgressBar : MonoBehaviour
{
    private int score = 0;
    private Image progressFillImage;
    private void Start()
    {
        progressFillImage = GetComponent<Image>();
    }
    private void OnEnable()
    {
        EventManager.OnPlayerReward.AddListener(UpdateProgressBar);
    }

    private void OnDisable()
    {
        EventManager.OnPlayerReward.RemoveListener(UpdateProgressBar);
    }

    private void UpdateProgressBar()
    {
        score++;
        if(score == 8)
        {
            EventManager.OnLevelWin.Invoke();
        }
        float val = (float)score / 15;
        progressFillImage.DOFillAmount(val, .8f);
    }
}
