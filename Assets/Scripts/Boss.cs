using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Boss : MonoBehaviour {

    public int health;
    public GameObject explosion;
    public Slider healthBar;
    public GameObject firewall;
    private float timeBtwFireWalls;
    public float startTimeBtwFireWalls;
    public GameObject player;


    // Use this for initialization
    void Start () {

        timeBtwFireWalls = startTimeBtwFireWalls;
        player = GameObject.FindGameObjectWithTag("Player");
  

    }

    // Update is called once per frame
     void Update(){

        healthBar.value = health;

        if (health <= 10){

            gameObject.transform.position = player.transform.position;

        }




        if (health <= 8){

            if (timeBtwFireWalls <= 0)
            {
                Instantiate(firewall, transform.position, Quaternion.identity);
                timeBtwFireWalls = startTimeBtwFireWalls;
            }
            else
            {
                timeBtwFireWalls -= Time.deltaTime;
            }
        }




        if (health <= 0){
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        
     }
    
    public void TakeDamage(int damage){
        health -= damage;
    }
}
