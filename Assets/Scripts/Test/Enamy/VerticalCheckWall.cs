using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalCheckWall : MonoBehaviour
{
    public Vector2 CatVector2d;
    public List<Vector2> WallVectors;
    public float InequalityVec2;
    public bool WallUp;
    public bool WallDown;



    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            WallVectors.Remove(other.gameObject.transform.position);
            WallUp = false;
            WallDown = false;
            gameObject.GetComponentInParent<EveCat>().WallDown = false;
            gameObject.GetComponentInParent<EveCat>().WallUp = false;
            BarrierAround();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            WallVectors.Add(other.gameObject.transform.position);
            BarrierAround();
            
        }
    }

    void BarrierAround()
    {
        {
            CatVector2d = gameObject.GetComponentInParent<Transform>().position;
        }
        for (int i = 0; i < WallVectors.Count; i++)
        {
            if (CatVector2d.y - WallVectors[i].y > 1.5f)
            {
                InequalityVec2 = CatVector2d.y - WallVectors[i].y;
                Debug.LogWarning("стена с низу" + InequalityVec2);
                WallDown = true;
                gameObject.GetComponentInParent<EveCat>().WallDown = true;
            }
            else if (CatVector2d.y - WallVectors[i].y < -1.5f)
            {
                InequalityVec2 = CatVector2d.y - WallVectors[i].y;
                Debug.LogWarning("стена с верху" + InequalityVec2);
                WallUp = true;
                gameObject.GetComponentInParent<EveCat>().WallUp = true;
            }
        }
    }
}

