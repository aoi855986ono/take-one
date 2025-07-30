using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClicks : MonoBehaviour
{
    public void OnButtonExit()
    {
        Application.Quit();
    }
    public void OnButtonGameStart()
    {
        SceneManager.LoadScene("InGameScene");
    }
}
