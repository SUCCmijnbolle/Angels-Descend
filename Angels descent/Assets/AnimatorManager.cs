using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    Animator animator;
    int horizontal;
    int vertical;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        horizontal = Animator.StringToHash("Horizontal");
        vertical = Animator.StringToHash("Vertical");
    }
    public void UpdateAnimatorValues(float HorizontalMovement, float VerticalMovement)
    {
        float snappedHorizontal;
        float snappedVertical;

        #region Snapped Horizontal
        if (HorizontalMovement > 0 && HorizontalMovement < 0.55f)
        {
            snappedHorizontal = 0.5f;
        }
        else if (HorizontalMovement > 0.55f)
        {
            snappedHorizontal = 1;
        }
        else if (HorizontalMovement < 0 && HorizontalMovement > -0.55f)
        {
            snappedHorizontal = -0.5f;
        }
        else if (HorizontalMovement < -0.55f)
        {
            snappedHorizontal = -1f;
        }
        else
        {
            snappedHorizontal = 0;
        }
        #endregion
        #region Snapped Vertical
        if (VerticalMovement > 0 && VerticalMovement < 0.55f)
        {
            snappedVertical = 0.5f;
        }
        else if (VerticalMovement > 0.55f)
        {
            snappedVertical = 1;
        }
        else if (VerticalMovement < 0 && VerticalMovement > -0.55f)
        {
            snappedVertical = -0.5f;
        }
        else if (VerticalMovement < -0.55f)
        {
            snappedVertical = -1f;
        }
        else
        {
            snappedVertical = 0;
        }
        #endregion

        animator.SetFloat(horizontal, snappedHorizontal, 0.1f, Time.deltaTime);
        animator.SetFloat(vertical, snappedVertical, 0.1f, Time.deltaTime);
    }
}
