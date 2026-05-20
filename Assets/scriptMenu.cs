using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMenu : MonoBehaviour
{
    public GameObject botaoIni;
    public GameObject botaoSair;

    public float tempoEspera = 10f;

    void Start()
    {
        // desativa os botões temporariamente
        botaoIni.SetActive(false);
        botaoSair.SetActive(false);

        // seta os botões após o tempo
        Invoke("AtivarBotoes", tempoEspera);
    }

    void AtivarBotoes()
    {
        botaoIni.SetActive(true);
        botaoSair.SetActive(true);
    }

    public void iniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
    }

    public void sair()
    {
        Application.Quit();
    }

    public void menu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}
