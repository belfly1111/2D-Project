using Unity.VisualScripting;
using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int isIdle = Animator.StringToHash("isIdle");
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
        animator.SetBool(isIdle, vector.magnitude < magnituteThreshold);
    }
}
