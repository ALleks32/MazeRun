using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed = 0.02f;
    public int MoveX;
    public int MoveY;

    public bool ChangeDirection = false;
    public int MoveIndex;
    //0 up
    //1 right
    //2 down
    //3 left

    Animator CatAnimator;
    SpriteRenderer BodyCat;

    public List<GameObject> VertHoriTrigers;
    void Start()
    {
        MoveIndexConroller();
        CatAnimator = gameObject.GetComponent<Animator>();
        BodyCat = gameObject.GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        Move();
        AnimationCat();
        MoveIndexConroller();
    }

    void OnCollisionEnter2D(Collision2D other)
    {


        for (int i = 0; i < VertHoriTrigers.Count; i++)
        {
            VertHoriTrigers[i].SetActive(true);
        }
        ChangeDirection = true;
    }
     void OnCollisionExit2D(Collision2D other)
    {
        for (int i = 0; i < VertHoriTrigers.Count; i++)
        {
            VertHoriTrigers[i].SetActive(false);
        }
        ChangeDirection = false;
    }

    void Move()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x + MoveX * Speed, gameObject.transform.position.y + MoveY * Speed);
    }


    void AnimationCat()
    {
        CatAnimator.SetFloat("Vertical", MoveY);
        CatAnimator.SetFloat("Horizontal", MoveX);
        if (CatAnimator.GetFloat("Horizontal") < 0)
        {
            BodyCat.flipX = true;
        }
        if (CatAnimator.GetFloat("Horizontal") > 0)
        {
            BodyCat.flipX = false;
        }
    }

    void MoveIndexConroller()
    {
        MoveX = 0;
        MoveY = 0;
        if (MoveIndex == 1)
        {
            MoveX = 1;
            
        }
        else if (MoveIndex == 0)
        {
            MoveY = 1;
        }
        else if (MoveIndex == 3)
        {
            MoveX = -1;
        }
        else if (MoveIndex == 2)
        {
            MoveY = -1;
        }



    }
}
