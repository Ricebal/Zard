using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] bool m_airControl = false;
    [SerializeField] float m_jumpForce = 400f;
    private bool m_facingRight = true;
    private Rigidbody2D m_rigidbody2D;
    private Vector3 m_velocity = Vector3.zero;
    private bool m_grounded = true;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move(float move, bool jump)
    {
        if (m_airControl || m_grounded)
        {
            Vector3 targetVelocity = new Vector2(move * 10f, m_rigidbody2D.velocity.y);
            m_rigidbody2D.velocity = targetVelocity;
            if ((move > 0 && !m_facingRight) || (move < 0 && m_facingRight))
            {
                Flip();
            }
        }

        if (m_grounded && jump)
        {
            // m_grounded = false;
            m_rigidbody2D.AddForce(new Vector2(0f, m_jumpForce));
        }
    }

    void Flip()
    {
        m_facingRight = !m_facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
