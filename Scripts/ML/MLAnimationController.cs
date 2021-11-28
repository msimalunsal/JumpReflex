using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MLAnimationController : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        EventManager.OnMLJump.AddListener(() => animator.SetBool("isJump" , true));
        EventManager.OnMLRun.AddListener(() => animator.SetBool("isJump", false));
    }

    private void OnDisable()
    {
        EventManager.OnMLJump.RemoveListener(() => animator.SetBool("isJump", true));
        EventManager.OnMLRun.RemoveListener(() => animator.SetBool("isJump", false));
    }
}
