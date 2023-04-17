using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate : MonoBehaviour
{
    private float crateHealth;
    void Start()
    {
        crateHealth = 1;
    }

    void Update()
    {
        if (crateHealth <= 0){
            Destroy(gameObject);
        }
    }

    public void takeDamage(){
        crateHealth--;
    }
}
