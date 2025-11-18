using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float lifespan = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Coin spawned");
    }

    // Update is called once per frame
    void Update()
    {
        lifespan = lifespan + 1 * Time.deltaTime;
        if (lifespan > 4)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Coin hit: " + col.name);
    }
}
