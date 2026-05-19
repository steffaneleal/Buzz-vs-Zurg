using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void sair()
    {
        Application.Quit();
    }

}
