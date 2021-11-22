using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Game closed");
        Application.Quit();
    }
}
