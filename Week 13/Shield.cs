using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public Animator shieldAnimator;

    public AudioSource shieldSounds;
    public AudioClip shieldDisabledClip;

    public GameManager gm;

    public AudioSource coinSounds;

    public bool shieldEnabled = false;
    float lifespan = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shield enabled");
    }

    // Update is called once per frame
    void Update()
    {
        if (shieldEnabled)
        {
            lifespan = lifespan + 1 * Time.deltaTime;
            if (lifespan > 10)
            {
                shieldAnimator.SetBool("ShieldEnabled", false);
                shieldSounds.PlayOneShot(shieldDisabledClip, 1);
                lifespan = 0;
                shieldEnabled = false;
            }
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (shieldEnabled)
        {
            Debug.Log("Shield hit: " + col.tag);
            if (col.gameObject.tag == "Enemy")
            {
                Destroy(col.gameObject);
            }
        }
    }
}
