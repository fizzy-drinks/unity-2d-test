using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBehaviour : MonoBehaviour
{
    public GameObject of;

    void Awake() {
        Debug.Log("Start spawning objects " + of.name + " with tag" + of.tag);
        InvokeRepeating("Spawn", 1f, 1f);
    }

    void Spawn() {
        var spawned = Instantiate(of, transform.position, transform.rotation);
        spawned.tag = of.tag;
    }
}
