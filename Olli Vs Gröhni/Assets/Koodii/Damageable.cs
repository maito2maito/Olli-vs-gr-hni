using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{

    Animator animator;

    [SerializeField]
    private float _maxHelth = 100;
    public float MaxHealth
    {
        get
        {
            return _maxHelth;
        }

        set
        {
            _maxHelth = value;
        }
    }

    public float _health = 100;

    public float Health
    {
        get
        {
            return _health;
        }

        set

        {
            _health = value;
            //jos heltti menee alle 0 niin hahmo ei en‰‰n el‰ 
            if (_health < 0)
            {
                isAlive = false;

            }
        }
    }
    [SerializeField]
    private bool isAlive = true;

    [SerializeField]
    private bool isInvincible = false;
 
    public bool IsAlive
    {
        get
        {
            return isAlive;
        }
        set
        {
            isAlive = value;
          
        }



    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

  


    public void Hit(int damage)
    {
        if(IsAlive && !isInvincible)
        {
            Health -= damage;
            isInvincible=true;

        }
    }
   
}
