using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerCell : MonoBehaviour
{
    public GameObject explode;
    private GameObject tripod;
    private GameObject crate;
    float removeTime = 3.0f;
    // Use this for initialization
    void Start () {
    tripod = GameObject.Find ("tripod");//find the tripod
    Destroy(gameObject, removeTime); //destory the object after 2s
    }


    void OnCollisionEnter(Collision other) {
    if (other.gameObject.tag == "Enemy") {
        //instantiate the explosion
        Instantiate(explode, transform.position, transform.rotation);
        //reduce the tripod's health
        tripod.GetComponent<triPodHealth>().reduceHealth();
        Destroy(gameObject);//destory self
    }
    else if (other.gameObject.tag == "Removable"){
        Debug.Log("Destroyed Crate");
        Instantiate(explode, transform.position, transform.rotation);
        other.gameObject.GetComponent<crate>().takeDamage();

    }
}
}
