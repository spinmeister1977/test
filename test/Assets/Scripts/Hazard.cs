using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;  
        PlayerHealth player = collider.GetComponent<PlayerHealth>();
        player.kill();
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
