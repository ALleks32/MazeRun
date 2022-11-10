using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    private GameObject TabloWinnes;
    void Awake()
    {
        TabloWinnes = GameObject.Find("WinesMenu");
    }
    void Start()
    {
        Time.timeScale = 1;
        TabloWinnes.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player_1" && gameObject.name == "Finish_1")
        {
            TabloWinnes.SetActive(true);
            GameObject.Find("Score").GetComponent<Text>().text ="Score " + other.gameObject.GetComponent<PlayerEating>().Score.ToString();
            GameObject.Find("WinnerName").GetComponent<Text>().text = "Player 1";
            Debug.Log("1win");
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Player_2" && gameObject.name == "Finish_2")
        {
            TabloWinnes.SetActive(true);
            GameObject.Find("Score").GetComponent<Text>().text = "Score " + other.gameObject.GetComponent<PlayerEating>().Score.ToString();
            GameObject.Find("WinnerName").GetComponent<Text>().text = "Player 2";
            Debug.Log("2win");
            Time.timeScale = 0;
        }
    }


}
