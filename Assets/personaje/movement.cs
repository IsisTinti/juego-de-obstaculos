using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class movement : MonoBehaviour
{
    public static movement obj;
    private Rigidbody2D myRB;
    public int Mariposingui;
    public string GameObject;
    public int vidas;
    public float movementspeed = 4;
    public bool PalancaOn_Off ;
    public Text mariposas;
    public GameObject lava;
    public int CantE;
    public Animator m_animator;
    Vector2 Movement;
    public Image vida1;
    public Image vida2;
    public Image vida3;
    public GameObject optionspanel;
    public AudioSource clip;

    public void Awake()
    {
        obj = this;
        myRB = GetComponent<Rigidbody2D>();
    }

    /*
    // Start is called before the first frame update*/
    void Start()
    {
        Mariposingui = 0;
        vidas = 3;
       
        madera = 0;

    }
        
    // Update is called once per frame
    void Update()
    {
        Movement.x = Input.GetAxis("Horizontal");
        Movement.y = Input.GetAxis("Vertical");

        m_animator.SetFloat("Horizontal", Movement.x);
        m_animator.SetFloat("Vertical", Movement.y);

        m_animator.SetFloat("Speed", Movement.sqrMagnitude);

        if (vidas == 1)
        {
            vida1.color = Color.white;
              vida2.color = Color.black;
            vida3.color = Color.black;  
           
        }
        else if (vidas <= 2)
        {   
            vida1.color = Color.white;
            vida2.color = Color.white;
            vida3.color = Color.black;
            
        }
        else if (vidas <= 3)
        {   vida1.color = Color.white; 
            vida2.color = Color.white;
            vida3.color = Color.white; 
        }
        mariposas.text = Mariposingui.ToString();

    }
    private void FixedUpdate()
    {
        myRB.MovePosition(myRB.position + Movement * movementspeed * Time.fixedDeltaTime);
        //myRB.velocity = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0) * movementspeed;
    }

    public void AddMariposingui()
    {
        Mariposingui++;
        

        if (Mariposingui >= 5 && vidas<3)
        {
            vidas++;
            Mariposingui -= 5;
            Debug.Log("oaaaa tenes una vida extra! vidas totales:" + vidas);
            
        }
    }
    
    public void activadorPalanca()
    {
        if (PalancaOn_Off==(true))
        {
            PalancaOn_Off = false;
            print("la palanquita esta en false");
           
        }
       
    }
    
    
    public void QuitarVida()
    {
        vidas--;
        clip.Play();
        if (vidas <= 0)
        {
            vida1.color = Color.white;
            vida2.color = Color.black;
            vida3.color = Color.black;
            Time.timeScale = 0;
            print("NOOOO QUE HICISTE CHINCHULIN TE MORISTE D;");
            SceneManager.LoadScene("pantallaDerrota");
        }
    }

    void OnDestroy()
    {
      //  obj = null;
    }
   
    public GameObject objetoSpawn;
    public Transform ubicacion;
    public GameObject objetoDelete;
    public int madera;
   
   

    public void CantMaderas()
    {
        madera++;
        Debug.Log("agarraste " + madera + "/3 maderas");
    }



    private void OnCollisionStay2D(Collision2D collision)
    {

        // v aca va la capa del personaje v / v aca va  la tecla de interaccion v 
        if (collision.gameObject.layer == 15 && Input.GetKey(KeyCode.E) && madera >= 3)
        {
            Debug.Log("apretaste la e"); 

            objetoSpawn = Instantiate(objetoSpawn, ubicacion.position, ubicacion.rotation);
            Debug.Log("spawneo " + objetoSpawn);
            Destroy(objetoDelete);
            Debug.Log("borro " + objetoDelete);
            madera -= 3;

        }

    }

} 

