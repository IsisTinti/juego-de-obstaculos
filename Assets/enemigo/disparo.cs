using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour
{
    public float bolitasSpeed;
    public float Tiempospawn;
    public GameObject punto;
    public GameObject bolitas;
    private float tiempovida;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          tiempovida += Time.deltaTime;
        if (tiempovida > Tiempospawn)
        {
            GameObject bullet = (GameObject)Instantiate(bolitas, punto.transform, true);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bolitasSpeed, bullet.GetComponent<Rigidbody2D>().velocity.y);
            
            Destroy (bullet,5);
            tiempovida = 0;
        }
    }
}
