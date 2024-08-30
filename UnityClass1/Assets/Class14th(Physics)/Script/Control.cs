using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        // ForceMode.Force : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� 0)
        // ForceMode.Acceleration : �������� ���� ���� ���� ������Ʈ�� �����̴� ����Դϴ�. (���� x)
        // ForceMode.Impulse : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� 0)
        // ForceMode.VelocityChange : �������� ���� ���� ���� ������Ʈ�� �����̴� ��� (���� x)

        rigidbody.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
    }

}
