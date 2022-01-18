using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.GetComponent<movement>())
        {
            collision.GetComponent<movement>().QuitarVida();
            Debug.Log("Tenes una vida menos...fijate tus movimientos");
            

        }
    }
}
