using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBuzz : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;

    private float altura;
    private float largura;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        vel = 10;

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect; // regra de 3, se precisar alterar por mudar a resolução da tela, deve ser colocado no Update
    }

    // Update is called once per frame
    void Update()
    {
        // setando as teclas de movimentação
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // aumentando a velocidade da movimentação
        rbd.velocity = new Vector2(x, y) * vel;

        // ajustando bordas laterais => se sair do enquadramento, volta do outro lado
        if (transform.position.x > largura)
        {
            transform.position = new Vector2(-largura, transform.position.y);
        } else if (transform.position.x < -largura) {
            transform.position = new Vector2(largura, transform.position.y);
        }

        // ajustando as alturas máxima e mínima
        if (transform.position.y > 0)
        {
            transform.position = new Vector2(transform.position.x, 0);
        } else if (transform.position.y < -5)
        {
            transform.position = new Vector2(transform.position.x, -altura);
        }
    }
}
