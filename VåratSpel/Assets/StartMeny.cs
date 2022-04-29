using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMeny : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Spelyta", LoadSceneMode.Single);
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        print("Avslutar");
    }


}
