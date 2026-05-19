using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBuzz : MonoBehaviour
{
    public GameObject tiroRaioLaser;

    private Rigidbody2D rbd;
    private AudioSource som;
    public float vel;

    private float altura;
    private float largura;
    private float alturaBuzz;

    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        som = this.GetComponent<AudioSource>();
        vel = 10;

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect; // regra de 3, se precisar alterar por mudar a resolução da tela, deve ser colocado no Update

        // descobrindo a altura do Buzz
        alturaBuzz = GetComponent<SpriteRenderer>().bounds.size.y;
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
        } else if (transform.position.y < -altura + (alturaBuzz / 2))
        {
            transform.position = new Vector2(transform.position.x, -altura + (alturaBuzz / 2));
        } // alturaBuzz / 2 pq o meio do game Object é onde fica o centro


        // instanciando o novo tiro
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) // quando pressiona (botão para baixo) a tecla de espaço ou o botão direito do mouse, libera o tiro
        {
            // som do tiro
            som.Play();
            
            Vector2 pos = new Vector2(transform.position.x, transform.position.y + (alturaBuzz/2));
            Instantiate(tiroRaioLaser, pos, Quaternion.identity);
        }
    }
}
