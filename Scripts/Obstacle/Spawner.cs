using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab = null;
    public Transform spawnPoint = null;

    public float min = 1.0f;
    public float max = 8f;

    private void OnEnable()
    {
        EventManager.OnLevelStart.AddListener(Spawn);
    }

    private void OnDisable()
    {
        EventManager.OnLevelStart.RemoveListener(Spawn);

    }
    // Start is called before the first frame update
    /*void Start()
    {
        Invoke("Spawn", Random.Range(min, max));
    }*/

    private void Spawn()
    {
        GameObject go = Instantiate(prefab);
        go.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        Invoke("Spawn", Random.Range(min, max));
    }

}
