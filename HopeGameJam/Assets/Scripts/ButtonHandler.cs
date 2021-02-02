using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

// ===============================
// AUTHOR: Emily Berg
// OTHER EDITORS: 
// DESC: Handles several different
// button actions we can re-use
// DATE MODIFIED: 2/1/2021
// ===============================


public class ButtonHandler : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("REMMIE");
    }

    public void Options()
    {
        //input code
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}