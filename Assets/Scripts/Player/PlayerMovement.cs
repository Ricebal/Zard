using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Animator m_animator = null;
    [SerializeField] private CharacterController2D m_controller = null;
    [SerializeField] private float m_speed = 40f;

    private float m_horizontalMove = 0f;
    private bool m_jump = false;

    // Update is called once per frame
    void Update()
    {
        m_horizontalMove = Input.GetAxisRaw("Horizontal") * m_speed;
        m_animator.SetFloat("Movement", Mathf.Abs(m_horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            m_jump = true;
            m_animator.SetBool("IsJumping", true);
        }
    }

    void FixedUpdate()
    {
        m_controller.Move(m_horizontalMove * Time.fixedDeltaTime, m_jump);
        m_jump = false;
    }

    public void ApexHandler()
    {
        m_animator.SetBool("IsFalling", true);
    }

    public void LandHandler()
    {
        m_animator.SetBool("IsJumping", false);
        m_animator.SetBool("IsFalling", false);
    }
}
