
public class WinPanel : Panel
{
    private void OnEnable()
    {
        EventManager.OnLevelWin.AddListener(ShowPanel);
        EventManager.OnLevelStart.AddListener(HidePanel);

    }

    private void OnDisable()
    {
        EventManager.OnLevelWin.RemoveListener(ShowPanel);
        EventManager.OnLevelStart.RemoveListener(HidePanel);

    }
}
