using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Criado a partir do Game Object ControladorRespawn, que não aparece no jogo (é um objeto vazio) mas serve para controlar apenas o spawn das naves
public class scriptRespawn : MonoBehaviour
{
    public GameObject naveZurg;

    private float largura;
    private float altura;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("respawnar", 0, 1); // método para instanciar um novo objeto a cada tantos segundos => ("nomeDaFunção", quando começar - aqui foi ao iniciar, no segundo 0, invoca a cada quanto tempo - em segundos)

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    private void respawnar()
    {
        // Definir a posição aleatória onde as naves vão spawnar
        float posX;
        posX = Random.Range(-largura, largura);

        // Criar um inimigo
        Vector2 pos = new Vector2(posX, Camera.main.orthographicSize);
        Instantiate(naveZurg, pos, Quaternion.identity); // (nome do Game Object que será instanciado, posição, rotação que vou dar)

        // Implementei no arquivo do inimigo (scriptNaveZurg.cs) um script para eliminar o inimigo toda vez que ele sai do frame e evitar vazamento de memória
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
