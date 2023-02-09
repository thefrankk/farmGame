using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    PlayerMovement direction;

    void Start()
    {
        animator = GetComponent<Animator>();
        direction = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        animator.SetFloat("Horizontal", direction.AxH);
        animator.SetFloat("Vertical", direction.AxV);

        if (direction.AxH != 0 || direction.AxV != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}
