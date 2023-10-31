using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horrizontal = Input.GetAxis("Horizontal");
        float vertiical = Input.GetAxis("Vertical");


        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horrizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertiical * Time.deltaTime;

        transform.position = position;
    }
}
