using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palanca : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var lava = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        
        //
        if (collision.gameObject.layer == 8 && Input.GetAxis("Action") != 0 )
        {
         //   collision.GetComponent<movement>().activadorPalanca();

            Debug.Log("apretaste la E bien ahi");
            GetComponent<SpriteRenderer>().flipX = true;
            var lava = GameObject.FindGameObjectWithTag("lava");
            var dique = GameObject.FindGameObjectWithTag("dique");
            Debug.Log(lava);
            Destroy(lava);
            Destroy(dique);
        }
        
      //
      //----------------------------------------------------------
      //-----------el coso de la palanca---------
      //CantE=0
      // var E = GameObject.FindGameObjectWithTag("E");
        /*  if (collision.gameObject.layer == 8 && CantE == 0)
          {
              CantE = 1;
              E = Instantiate(E);
              Debug.Log("te deberia aparecer la E");
          }
          else Destroy(E);
          Debug.Log("se borro la E");*/
        //
        //
    }
}

