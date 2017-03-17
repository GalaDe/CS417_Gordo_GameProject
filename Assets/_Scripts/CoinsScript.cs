using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinsScript : MonoBehaviour {


    public float rotateSpeed = 10f;
    private Animator anim;
    public PlayerControl player { get; set; }
    public GameObject coin;
    public int countCoits = 0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }



    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    Debug.Log(other.gameObject.name);

    //    if (other.tag.Equals("Pick Up"))
    //    {
    //        //Calculate points -- 100max for 1st level 
    //        other.gameObject.SetActive(false);
    //        if (score <= 100)
    //        {
  
    //            Debug.Log(score);
    //        }
  

    //    }
    //}





}
