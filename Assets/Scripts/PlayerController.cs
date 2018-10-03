using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Inventory inventory;

    public int playerSpeed = 2;

    Rigidbody rigid;

    Vector3 input;

    public int playerSuffix;

    // Use this for initialization
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        input = new Vector3(Input.GetAxis("Horizontal" + playerSuffix), 0, Input.GetAxis("Vertical" + playerSuffix));
        rigid.velocity = new Vector3(input.x * playerSpeed, rigid.velocity.y, input.z * playerSpeed);
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
