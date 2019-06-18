using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Animator m_animator;
    [SerializeField] private CharacterController2D m_controller = null;
    [SerializeField] private float m_speed = 40f;

    private float m_horizontalMove = 0f;
    private bool m_jump = false;

    // Update is called once per frame
    void Update()
    {
        m_horizontalMove = Input.GetAxisRaw("Horizontal") * m_speed;

        if (Input.GetButtonDown("Jump"))
        {
            m_jump = true;
        }
    }

    void FixedUpdate()
    {
        m_controller.Move(m_horizontalMove * Time.fixedDeltaTime, m_jump);
        m_jump = false;
    }
}
