using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float spd = 5;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Vector3 direct = Vector3.right * h + Vector3.up * v;
        Vector3 direct = new Vector3(h, v, 0);
        //transform.Translate(direct* spd* Time.deltaTime);
        transform.position = transform.position + direct * spd * Time.deltaTime;

        //Debug.Log("h : " + h + ",v :" + v);

        //transform.Translate(Vector3.right * 5 * Time.deltaTime);

    }
}
