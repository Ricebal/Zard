using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Animator m_animator = null;
    [SerializeField] private CharacterController2D m_controller = null;
    [SerializeField] private float m_speed = 40f;
    [SerializeField] private Transform m_cameraTransform;

    private float m_horizontalMove = 0f;
    private bool m_jump = false;

    // Update is called once per frame
    void Update()
    {
        // Get horizontal movement input and set animation parameter
        m_horizontalMove = Input.GetAxisRaw("Horizontal") * m_speed;
        m_animator.SetFloat("Movement", Mathf.Abs(m_horizontalMove));

        // If the player is jumping set jump to true and set animation parameter
        if (Input.GetButtonDown("Jump"))
        {
            m_jump = true;
            m_animator.SetBool("IsJumping", true);
        }

        // Make camera follow player
        Vector3 cameraPos = new Vector3(transform.position.x, m_cameraTransform.position.y, m_cameraTransform.position.z);
        m_cameraTransform.position = cameraPos;
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
