using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Move(){
        float Horizontal = Input.GetAxis("Horizontal");
        float Vetical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(Horizontal,Vetical)*Time.deltaTime;
    }
}
