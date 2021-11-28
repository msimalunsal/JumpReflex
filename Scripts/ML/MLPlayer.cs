using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class MLPlayer : Agent
{
    public float force = 15f;
    private Rigidbody rb = null;
    public Transform originalPosition;

    private void Update()
    {
        if(transform.localPosition.y >= 0.17)
        {
            EventManager.OnMLJump.Invoke();
        }
    }
    public override void Initialize() // Start
    {
        rb = GetComponent<Rigidbody>();
        originalPosition = transform;
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        if (vectorAction[0] == 1)
        {
            Thrust();
        }
    }
    
    public override void OnEpisodeBegin()
    {
        ResetPlayer();
    }
    
    public override void Heuristic(float[] actionsOut)
    {
        actionsOut[0] = 0;
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            actionsOut[0] = 1;
        }
    }

    private void Thrust()
    {
        rb.AddForce(Vector3.up * force, ForceMode.Acceleration);
    }

    private void ResetPlayer()
    {
       transform.position = new Vector3(originalPosition.position.x, originalPosition.position.y, originalPosition.position.z);
    }
    
    private void OnCollisionEnter(Collision collision)//punish
    {
        if(collision.gameObject.CompareTag("Obstacle") == true)
        {
            AddReward(-1.0f);
            Destroy(collision.gameObject);
            EndEpisode();
        }

        if (collision.gameObject.CompareTag("WallTop") == true)
        {

            AddReward(-1.0f);
            EndEpisode();
        }

        if(collision.gameObject.CompareTag("Floor") == true)
        {
            EventManager.OnMLRun.Invoke();
        }

    }

    private void OnTriggerEnter(Collider other)//reward
    {
        if (other.CompareTag("WallReward") == true)
        {

            AddReward(0.1f);
        }
    }
}
