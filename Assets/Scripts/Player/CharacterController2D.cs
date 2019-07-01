using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] bool m_airControl = false;
    [SerializeField] float m_jumpForce = 400f;
    private bool m_facingRight = true;
    private Rigidbody2D m_rigidbody2D;
    private Vector3 m_velocity = Vector3.zero;
    private bool m_grounded = true;
    private bool m_isJumping = false;

    [Header("Events")]
    [Space]

    public UnityEvent OnLandEvent;
    public UnityEvent OnApexEvent;
    public UnityEvent OnEnterBenchEvent;
    public UnityEvent OnExitBenchEvent;

    private void Awake()
    {
        m_rigidbody2D = GetComponent<Rigidbody2D>();

        if (OnLandEvent == null)
            OnLandEvent = new UnityEvent();

        if (OnApexEvent == null)
            OnApexEvent = new UnityEvent();

        if (OnEnterBenchEvent == null)
            OnEnterBenchEvent = new UnityEvent();

        if (OnExitBenchEvent == null)
            OnExitBenchEvent = new UnityEvent();
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
            m_grounded = false;
            m_isJumping = true;
            m_rigidbody2D.AddForce(new Vector2(0f, m_jumpForce));
        }

        if (m_rigidbody2D.velocity.y < 0 && !m_grounded)
        {
            m_isJumping = false;
            OnApexEvent?.Invoke();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Ground")
        {
            m_grounded = true;
            m_isJumping = false;
            OnLandEvent?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "SCBench")
        {
            OnEnterBenchEvent?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.tag == "SCBench")
        {
            OnExitBenchEvent?.Invoke();
        }
    }

    void Flip()
    {
        m_facingRight = !m_facingRight;

        transform.Rotate(0f, 180f, 0f);
    }
}
