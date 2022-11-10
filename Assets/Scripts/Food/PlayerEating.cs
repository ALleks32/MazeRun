using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEating : MonoBehaviour
{
    public int Score;
    public Text ScoreTablo;
    private BoxCollider2D EatingZone;



    void Start()
    {
       
       // ScoreTablo = gameObject.GetComponentInChildren<Text>();
        EatingZone = gameObject.GetComponent<BoxCollider2D>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<FoodProperty>())
        {
            Score += collision.gameObject.GetComponent<FoodProperty>().Score;
            Destroy(collision.gameObject);
            ScoreTablo.text =Score.ToString();
}
    }
}
