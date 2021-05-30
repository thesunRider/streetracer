using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_characters : MonoBehaviour
{

    private Rigidbody car_rigid;
    // Start is called before the first frame update
    void Start()
    {
        car_rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trans = new Vector3(0, 0, 1);
       // car_rigid.transform.position = trans;
    }
}
