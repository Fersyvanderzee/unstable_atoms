using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sys_destroyer : MonoBehaviour
{
    public float gravityScaleFactor;

    void Start(){
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityScaleFactor;
        
    }

    void Update()
    {
        if(transform.position.y < -10f){
            FindObjectOfType<game_score>().score += 10;
            Destroy(gameObject);
        }
    }
}
