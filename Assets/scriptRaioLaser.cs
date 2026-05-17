using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptRaioLaser : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {
        vel = 11;

        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0, vel);
    }

    // Update is called once per frame
    void Update()
    {
        // Tiro se autodestrói quando passar da borda da tela
        if (transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(gameObject);    
        }
    }
}