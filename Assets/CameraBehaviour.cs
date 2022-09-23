using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject follow;
    public Vector3 velocity = Vector3.zero;
    public Vector3 offset;
    public float smoothTime = .15f;

    void FixedUpdate() {
        transform.position = new Vector3(follow.transform.position.x + offset.x, follow.transform.position.y + offset.y, transform.position.z);
    }
}
