using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EveCat : MonoBehaviour
{

    public bool WallRight;
    public bool WallLeft;
    public bool WallUp;
    public bool WallDown;

    //0 up
    //1 right
    //2 down
    //3 left
    private void FixedUpdate()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //1 куда идет
        //#преграда
        //0 пройденый путь
        //* текущее положение

        //  # 
        //1 * #
        //  0 
        if (WallRight == false && WallUp == true && WallLeft == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 1;
        }
        //  # 
        //# * 1
        //  0 
        else if (WallRight == true && WallUp == true && WallLeft == false)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 3;
        }
        //  # 
        //# * #
        //  1 
        else if (WallRight == true && WallUp == true && WallLeft == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 3;
        }
        //  # 
        //1 * 1
        //  0 
        else if (WallRight == false && WallUp == true && WallLeft == false)
        {
            if (UnityEngine.Random.Range(0, 1) != 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 1;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 3;
            }
        }

        //  1 
        //0 * #
        //  # 
        if (WallRight == false && WallUp == true && WallDown == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 0;
        }
        //  # 
        //0 * #
        //  1 
        else if (WallRight == true && WallUp == true && WallDown == false)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 2;
        }
        //  # 
        //0 * #
        //  # 
        else if (WallRight == true && WallUp == true && WallDown == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 3;
        }
        //  1 
        //0 * #
        //  1 
        else if (WallRight == true && WallUp == false && WallDown == false)
        {
            if (UnityEngine.Random.Range(0, 1) != 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 0;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 2;
            }
        }


        //  1 
        //# * 0
        //  # 
        if (WallLeft == true && WallUp == false && WallDown == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 0;
        }
        //  # 
        //# * 0
        //  1 
        else if (WallLeft == true && WallUp == true && WallDown == false)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 2;
        }
        //  # 
        //# * 0
        //  # 
        else if (WallLeft == true && WallUp == true && WallDown == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 1;
        }
        //  1 
        //# * 0
        //  1 
        else if (WallLeft == true && WallUp == false && WallDown == false)
        {
            if (UnityEngine.Random.Range(0, 1) != 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 0;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 2;
            }
        }


        //  0 
        //# * 1
        //  # 
        if (WallLeft == true && WallDown == true && WallRight == false)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 1;
        }
        //  0 
        //1 * #
        //  # 
        else if (WallLeft == false && WallDown == true && WallRight == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 3;
        }
        //  0 
        //# * #
        //  # 
        else if (WallLeft == true && WallDown == true && WallRight == true)
        {
            gameObject.GetComponent<Movement>().MoveIndex = 0;
        }
        //  0 
        //1 * 1
        //  # 
        else if (WallLeft == false && WallDown == true && WallRight == false)
        {
            if (UnityEngine.Random.Range(0, 1) != 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 1;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 3;
            }
        }
        //  #
        //0 * 0
        //  # 

        else if (WallRight == false && WallUp == true && WallLeft == false && WallDown == true)
        {
            if (UnityEngine.Random.Range(0, 1) == 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 1;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 3;
            }
        }

        //  0
        //# * #
        //  0 

        else if (WallRight == true && WallUp == false && WallLeft == true && WallDown == false)
        {
            if (UnityEngine.Random.Range(0, 1) == 0)
            {
                gameObject.GetComponent<Movement>().MoveIndex = 0;
            }
            else
            {
                gameObject.GetComponent<Movement>().MoveIndex = 2;
            }
        }
    }
}