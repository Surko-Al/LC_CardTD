using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public Player player;
    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        InputHandle();
        Jumping();
    }
    private void InputHandle()
    {
        player.horizontalInput = Input.GetAxis("Horizontal");
        player.verticalInput = Input.GetAxis("Vertical");
    }
    private void Jumping() 
    {
        if (Input.GetButtonDown("Jump"))
        {
            player.isJump = true;
            return;
        }
        player.isJump = false;
    }
}
