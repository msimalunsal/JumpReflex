
public class FailPanel : Panel
{
    private void OnEnable()
    {
        EventManager.OnLevelFail.AddListener(ShowPanel);
        EventManager.OnLevelStart.AddListener(HidePanel);

    }

    private void OnDisable()
    {
        EventManager.OnLevelFail.RemoveListener(ShowPanel);
        EventManager.OnLevelStart.RemoveListener(HidePanel);

    }
}
