using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firewall : MonoBehaviour {

    public float speed;
    private Transform player;
    private Vector2 target;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x) {
            DestroyFirewall();
        }
	}

    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")) {
            DestroyFirewall();
        }
    }

    void DestroyFirewall(){
        Destroy(gameObject);
    }
}
