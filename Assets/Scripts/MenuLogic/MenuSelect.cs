using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuSelect : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Office Floorplan Backup");
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }

}
