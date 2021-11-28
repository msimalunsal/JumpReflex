using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnEnable()
    {
        EventManager.OnPlayerJump.AddListener(TriggerJump);
        EventManager.OnPlayerRun.AddListener(() => animator.SetBool("isJump", false));


    }

    private void OnDisable()
    {
        EventManager.OnPlayerJump.RemoveListener(TriggerJump);
        EventManager.OnPlayerRun.RemoveListener(() => animator.SetBool("isJump", false));

    }

    private void TriggerJump()
    {
        animator.SetBool("isJump", true);
    }

}
