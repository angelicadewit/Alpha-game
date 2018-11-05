using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public float distance;
    public int damage;
    public LayerMask bossLayer;

    // Use this for initialization
    void Start () {
        Invoke("DestroyProjectile", lifeTime);
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, distance, bossLayer);

        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Boss"))
            {
                hitInfo.collider.GetComponent<Boss>().TakeDamage(damage);
            }
            DestroyProjectile();
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile(){
        Destroy(gameObject);
    }
}
