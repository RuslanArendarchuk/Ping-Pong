using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIM : MonoBehaviour
{
    public GameObject pauseGameMenu;
    [SerializeField] private GameObject PanelWin;
    [SerializeField] private GameObject PanelLose;

    public void Win()
    {
        PanelWin.SetActive(true);
        Time.timeScale = 0;
        
    }

    public void Lose()
    {
        PanelLose.SetActive(true);
        Time.timeScale = 0;
    }

}
