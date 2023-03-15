using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public Rigidbody Rb;
    public FixedJoystick Joystick;
    public float moveSpeed;
    public Animator anim;
    public bool walk;
    public bool mow;

    void Start()
    {
        instance = this;
    }

    void FixedUpdate()
    {
        Rb.velocity = new Vector3(Joystick.Horizontal * moveSpeed, Rb.velocity.y, Joystick.Vertical * moveSpeed);

        if (Joystick.Horizontal != 0 || Joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Rb.velocity);
            
            mow = false;
            walk = true;
            
        }

        else

        {
            walk = false;
        }

        anim.SetBool("animWalk", walk);
        anim.SetBool("animMow", mow);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Rye")
        {
            mow = true;
        }
        if (other.tag == "Untagged")
        {
            mow = false;
        }
    }

}
