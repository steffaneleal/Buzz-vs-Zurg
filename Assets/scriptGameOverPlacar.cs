using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scriptGameOverPlacar : MonoBehaviour
{
    public TMP_Text pontuacaoFinal;

    void Start()
    {
        int pontuacao = scriptPlacar.getPlacar();

        pontuacaoFinal.text = "Placar: " + pontuacao;
    }
}
