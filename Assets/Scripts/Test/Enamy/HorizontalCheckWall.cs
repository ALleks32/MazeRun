using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalCheckWall : MonoBehaviour
{
    public Vector2 CatVector2d;
    public List<Vector2> WallVectors;
    public float InequalityVec2;
    public bool WallRight;
    public bool WallLeft;
    private void FixedUpdate()
    {

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            //Debug.LogError("не Вижу");
            WallVectors.Remove(other.gameObject.transform.position);
            WallRight = false;
            WallLeft = false;
            gameObject.GetComponentInParent<EveCat>().WallRight = false;
            gameObject.GetComponentInParent<EveCat>().WallLeft = false;
            BarrierAround();

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            // Debug.LogError("Вижу");

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
            if (CatVector2d.x - WallVectors[i].x > 1.5f)
            {
                InequalityVec2 = CatVector2d.x - WallVectors[i].x;

                Debug.LogWarning("стена с лево" + InequalityVec2);
                WallLeft = true;
                gameObject.GetComponentInParent<EveCat>().WallLeft = true;
            }
            else if (CatVector2d.x - WallVectors[i].x < -1.5f)
            {
                InequalityVec2 = CatVector2d.x - WallVectors[i].x;

                Debug.LogWarning("стена с право" + InequalityVec2);
                WallRight = true;
                gameObject.GetComponentInParent<EveCat>().WallRight = true;
            }
        }

    }
}
