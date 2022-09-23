using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody2D rb;
    
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        var moveDirection = transform.rotation.y != 0 ? -1 : 1;
        rb.velocity = new Vector2(moveDirection * projectileSpeed, 0);
    }
   
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "enemy") {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
}
