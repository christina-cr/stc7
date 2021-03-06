﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


public class MenuUi : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    

    public Button button0, button1, button2;
    public Text typeText;
    public GameObject nExample;


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void Awake()
    {
        //--------------

        button0.onClick.AddListener(Button0);
        button1.onClick.AddListener(Button1);
        button2.onClick.AddListener(Button2);

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void LateUpdate()
    {
        //--------------

        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();

        typeText.text = nExample.activeSelf ? "#NVJOB Shader for Unity SpeedTree 7" : "Standard Shader for Unity SpeedTree 7";

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    void Button0()
    {
        //--------------

        SceneManager.LoadScene("Example 0 (Deferred)", LoadSceneMode.Single);

        //--------------
    }

    void Button1()
    {
        //--------------

        SceneManager.LoadScene("Example 1 (Forward)", LoadSceneMode.Single);

        //--------------
    }

    void Button2()
    {
        //--------------

        SceneManager.LoadScene("Example 2 (Deferred)", LoadSceneMode.Single);

        //--------------
    }


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}