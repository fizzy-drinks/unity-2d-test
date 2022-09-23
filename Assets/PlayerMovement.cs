using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public GameObject projectile;
    private Rigidbody2D rb;
    private Collider2D coll;
    
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    void Update()
    {
        var moveDirection = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveDirection * moveSpeed, 0);

        if (moveDirection > 0) {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        } else if (moveDirection < 0) {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }

        var isFiring = Input.GetButtonDown("Fire1");
        if (isFiring) {
            float currentX = transform.position.x;
            float offsetX = coll.bounds.size.x / 2f;
            Vector3 projectilePosition = new Vector3(currentX + offsetX, transform.position.y, transform.position.z);
            Instantiate(projectile, projectilePosition, transform.rotation);
        }
    }
}
