using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class victoria : MonoBehaviour
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
            Debug.LogError("SE ROMPIO TODO mentira wachin ganaste bien ahi <3");
            SceneManager.LoadScene("victoria");
        }
        else if (collision.GetComponent<movement>()&& movement.obj.vidas<=0)
        {
            Debug.Log("ah pero no tenes vidas gasparin,full tramposo :o");
        }
    }
}
