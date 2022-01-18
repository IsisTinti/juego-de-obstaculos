using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class interactionwood : MonoBehaviour
{
    public AudioSource clip;
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
       
        if (collision.gameObject.layer == 8)
        {
             clip.Play();
            
            collision.GetComponent<movement>().CantMaderas();
            Debug.Log("agarraste una madera");
           GetComponent<BoxCollider2D>().enabled = false;
            Destroy(this.gameObject,1f);
            
        }
    }
}
