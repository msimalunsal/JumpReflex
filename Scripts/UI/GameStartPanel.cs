public class GameStartPanel : Panel
{
    private void OnEnable()
    {
        EventManager.OnLevelStart.AddListener(HidePanel);
    }

    private void OnDisable()
    {
        EventManager.OnLevelStart.RemoveListener(HidePanel);
    }
}
