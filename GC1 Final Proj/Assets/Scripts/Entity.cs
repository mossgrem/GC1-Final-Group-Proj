using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private float StartingHealth;
    private float health;
    public Animator animator;

    public float Health
    {
    get
        {
            return health;
        }
        set
        {
            health = value;
            Debug.Log(health);

            if (health <= 0f)
            {
                animator.SetBool("dead", true);
            }
        }
    }


    void Start()
    {
        Health = StartingHealth;
        animator.SetBool("dead", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
