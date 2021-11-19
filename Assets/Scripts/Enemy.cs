using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;

    [SerializeField] private AudioSource deathSound;

    void Start()
    {

    }
    
    public void Die()
    {
        deathSound.Play();
        GetComponent<Collider2D>().enabled = false;
        animator.SetBool("IsDead", true);

    }

    public void DisableEnemy()
    {
        
        GetComponent<SpriteRenderer>().enabled = false;
        this.enabled = false;
    }


}
