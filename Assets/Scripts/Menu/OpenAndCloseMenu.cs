using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAndCloseMenu : MonoBehaviour
{
    public GameObject MenuUI;
    void Start()
    {
        MenuUI = GameObject.Find("Menu");
        MenuUI.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) && MenuUI.activeSelf == true)
        {
            BackGame();
        }
        else if (Input.GetKeyUp(KeyCode.Escape) && MenuUI.activeSelf == false)
        {
            MenuUI.gameObject.SetActive(true);
        }
    }
    void BackGame()
    {
        MenuUI.gameObject.SetActive(false);

    }

}
