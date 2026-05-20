using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptControladorJogo : MonoBehaviour
{
    private bool pausa;

    void Start()
    {
        pausa = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa)
            {
                // DESPAUSAR
                Time.timeScale = 1;
                
                // Usamos o descarregamento normal
                SceneManager.UnloadSceneAsync(3);
                pausa = false;
            } 
            else
            {
                // PAUSAR
                // 1. Mudamos a variável primeiro
                pausa = true; 
                
                // 2. Carregamos a cena IMEDIATAMENTE (sem o Async para não travar no frame zero)
                SceneManager.LoadScene(3, LoadSceneMode.Additive);
                
                // 3. Congelamos o tempo DEPOIS que a cena já foi forçada a entrar na hierarquia
                Time.timeScale = 0;
            }
        }
    }
}