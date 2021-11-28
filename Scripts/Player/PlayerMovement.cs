using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlayerMovement : MonoBehaviour
{
    private bool canJump = true;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canJump)
        {
            EventManager.OnPlayerJump.Invoke();
            Jump();
            canJump = false;
        }

    }

    void Jump()
    {
        transform.DOLocalMoveY(-5.8f, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            EventManager.OnPlayerRun.Invoke();
            canJump = true;
        }
    }
}
