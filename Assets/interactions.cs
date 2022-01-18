using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class interactions : MonoBehaviour
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
      if (collision.GetComponent<movement>())
        {
         
            collision.GetComponent<movement>().AddMariposingui();
            Debug.Log("Agarraste la mariposingui");
            GetComponent<BoxCollider2D>().enabled = false;
            Destroy(this.gameObject,1.5f) ;
             clip.Play();
        }

    }
}
