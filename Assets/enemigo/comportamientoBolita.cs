using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoBolita : MonoBehaviour
{
    public float speed = 2;
    public float lifetime = 2;
    public bool left;

    private void Start()
    {
        Destroy(gameObject,lifetime);
    }

    // Update is called once per frame
    private void Update()
    {
        if(left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
