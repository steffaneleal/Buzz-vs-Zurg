using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNaveZurg : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel = 5;

    void OnTriggerEnter2D(Collider2D collision)
    {
        scriptPlacar.addPlacar(100);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, -vel); // -vel pq a velocidade deve ser para baixo
    }

    // Update is called once per frame
    void Update()
    {
        // Script para eliminar o inimigo toda vez que ele sai do frame e evitar vazamento de memória
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}
