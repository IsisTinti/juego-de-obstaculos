using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoQuePatrulla : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] PuntosMovimiento;
    [SerializeField] private float distanciaMinima;
    private int numeroAleatorio;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        numeroAleatorio = Random.Range(0, PuntosMovimiento.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PuntosMovimiento[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, PuntosMovimiento[numeroAleatorio].position) < distanciaMinima)
        {
            numeroAleatorio = Random.Range(0, PuntosMovimiento.Length);
            Girar();
        }
    }
    private void Girar()
    {
        if(transform.position.x<PuntosMovimiento[numeroAleatorio].position.x)
            {
            spriteRenderer.flipX = true;
            }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

    }
}

