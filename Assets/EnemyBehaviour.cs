using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float moveSpeed;

    private Rigidbody2D rb;
    private GameObject player;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        if (rb.velocity.y == 0) {
            var moveDirection = player.transform.position.x > transform.position.x ? 1 : -1;
            rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        }
    }
}
