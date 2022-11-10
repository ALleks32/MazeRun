using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer2 : MonoBehaviour
{
    public float moveSpeed;
    Animator PlayerAnimator;

    SpriteRenderer BodyPlayer;
    BoxCollider2D ColRotate;

    private void Start()
    {
        PlayerAnimator = gameObject.GetComponent<Animator>();
        BodyPlayer = gameObject.GetComponent<SpriteRenderer>();
        ColRotate = gameObject.GetComponent<BoxCollider2D>();
    }
    private void FixedUpdate()
    {
       
        MoveController();
        AnimationPlayer();
    }

    void MoveController()
    {
        float forwardMove = Input.GetAxis("Vertical2") * moveSpeed;
        float sideMove = Input.GetAxis("Horizontal2") * moveSpeed;

        gameObject.transform.position = new Vector2(gameObject.transform.position.x + sideMove, gameObject.transform.position.y + forwardMove);





    }
    void AnimationPlayer()
    {
        PlayerAnimator.SetFloat("Vertical", Input.GetAxis("Vertical2"));

        PlayerAnimator.SetFloat("Horizontal", Input.GetAxis("Horizontal2"));

        if (PlayerAnimator.GetFloat("Horizontal") < 0)
        {
            if (ColRotate.offset.x > 0f)
            {
                ColRotate.offset = new Vector2(-ColRotate.offset.x, ColRotate.offset.y);
            }
            BodyPlayer.flipX = true;
        }
        if (PlayerAnimator.GetFloat("Horizontal") > 0)
        {
            BodyPlayer.flipX = false;
        }
    }
}
