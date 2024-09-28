using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private Transform _pointA;
    [SerializeField] private Transform _pointB;
    private Vector3 m_distance;

    [SerializeField] private float m_maxSpeed;
    private Vector3 m_maxVelocity;

    [SerializeField] private float _duration;
    private float m_timer;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

        transform.position = _pointA.position;

        m_timer = 0f;
    }
        
    private void FixedUpdate()
    {
        m_timer += Time.deltaTime;

        if (m_timer < _duration * .5f)
        {
            m_distance = _pointB.position - transform.position;

            _rb.velocity = Vector3.Lerp(Vector3.zero, m_distance, m_timer / _duration);
        }
        else
        {
            m_distance = _pointB.position - transform.position;

            _rb.velocity = Vector3.Lerp(m_distance, Vector3.zero, m_timer / _duration);
        }

    }
}
