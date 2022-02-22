using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public bool OnGround;
    public float JumpForce = 200f;
    public float DeathRay = -55;
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        print(SpawnPoint.transform.position.y);
        if(Input.GetButton("Jump")&& OnGround){
            playerRB.AddForce(transform.up * JumpForce);
            OnGround = false;
        }
        //print(transform.position.y);
        if(transform.position.y < DeathRay)
            transform.position = SpawnPoint.transform.position;
            print("you died");
    } 


    void OnCollisionEnter2D(Collision2D other){
        OnGround = true;
        print("collison");
    }
}
