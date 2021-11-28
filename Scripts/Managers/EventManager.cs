using UnityEngine.Events;

public static class EventManager
{
    #region Game State Events
    public static UnityEvent OnGameStart = new UnityEvent();
    public static UnityEvent OnGameOver = new UnityEvent();
    #endregion

    #region Level Events
    public static UnityEvent OnLevelStart = new UnityEvent();
    public static UnityEvent OnLevelWin = new UnityEvent();
    public static UnityEvent OnLevelFail = new UnityEvent();

    #endregion

    #region ML Events
    public static UnityEvent OnMLHits = new UnityEvent();
    public static UnityEvent OnMLReward = new UnityEvent();
    public static UnityEvent OnMLJump = new UnityEvent();
    public static UnityEvent OnMLRun = new UnityEvent();

    #endregion

    #region Player Events
    public static UnityEvent OnPlayerJump = new UnityEvent();
    public static UnityEvent OnPlayerRun = new UnityEvent();
    public static UnityEvent OnPlayerReward = new UnityEvent();
    #endregion
}