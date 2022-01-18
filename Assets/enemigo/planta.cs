using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planta : MonoBehaviour
{
    private float waitedTime;
    public float waitTimeToAttack;
    public GameObject BulletPrefab;
    public Transform SpawnPoint;
    public Animator p_animator;
   // public bool attacking = false;



    private void Start()
    {
        waitedTime = waitTimeToAttack;
        
    }
    private void Update()
    
    {
        if (waitedTime<=0)
        {
                
            waitedTime = waitTimeToAttack;
           p_animator.Play("attack");
            Invoke("LaunchBullet", 0.5f);
             p_animator.Play("idleAnim");
        }
        else
        {
        // p_animator.SetBool("attacking",false); 
            
            waitedTime -= Time.deltaTime;
         
          

         
        }

    }
    public void LaunchBullet ()
    {
           
        GameObject NewBullet;
          
        NewBullet = Instantiate(BulletPrefab, SpawnPoint.position, SpawnPoint.rotation);
   
        
    }
}
