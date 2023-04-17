using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    //public GameObject player;
    //shooter pickUp;
    //public int no_cell2;
    public AudioClip collectSound;
    void Start()
    {
        //no_cell2 = player.gameObject.GetComponent<shooter>().no_cell;
        //player = GameObject.FindGameObjectWithTag("Player");
        // pickUp = GameObject.FindGameObjectWithTag("Player").GetComponent<shooter>().pickUp();
    }

    void Update()
    {
        transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player"){
            Debug.Log("Intersection");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<shooter>().pickUp();
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            //other.gameObject.GetComponent<shooter>().pickUp();
            gameObject.SetActive(false);
        }

    }
}
