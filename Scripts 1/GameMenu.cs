﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Classroom");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }

}
