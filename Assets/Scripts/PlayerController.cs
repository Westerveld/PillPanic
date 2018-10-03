using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    public Inventory inventory;

    public int playerSpeed = 2;

    Rigidbody rigid;

    Vector3 input;

    public int playerSuffix;

    public bool buttonPressed;

    public int[] pills;

    // Use this for initialization
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        inventory = new Inventory();
    }

    private void FixedUpdate()
    {
        input = new Vector3(Input.GetAxis("Horizontal" + playerSuffix), 0, Input.GetAxis("Vertical" + playerSuffix));
        rigid.velocity = new Vector3(input.x * playerSpeed, rigid.velocity.y, input.z * playerSpeed);
        
        if (Input.GetButtonDown("Fire" + playerSuffix))
            buttonPressed = true;
        else
            buttonPressed = false;

        pills = inventory.PillsInInventory;
    }

    // Update is called once per frame
    void Update ()
    {
        
    }
}
