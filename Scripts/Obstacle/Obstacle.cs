using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed = 3.5f;
    public GameObject CollectParticlePrefab;

    void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("WallEnd") == true)
        {
            EventManager.OnMLReward.Invoke();
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.CompareTag("MLPlayer") == true || collision.gameObject.CompareTag("Player") == true)
        {
            if(collision.gameObject.CompareTag("Player") == true)
            {
                Destroy(this.gameObject);
            }
            Instantiate(CollectParticlePrefab, transform.position, Quaternion.identity);
        }

        else if(collision.gameObject.name == "DestroyPoint")
        {
            EventManager.OnPlayerReward.Invoke();
            Destroy(this.gameObject);
        }
    }
}
