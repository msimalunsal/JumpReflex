using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameStartButton : Button
{
    protected override void OnEnable()
    {
        base.OnEnable();

        onClick.AddListener(StartLevel);
    }
    protected override void OnDisable()
    {
        base.OnDisable();

        onClick.RemoveListener(StartLevel);
    }

    void StartLevel()
    {
        EventManager.OnLevelStart.Invoke();
    }
}
