using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    WALK,
    ATTACK,
    DIE
}
public class Knight : MonoBehaviour
{
    [SerializeField] State state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed = 5f; // �̵� �ӵ�

    void Update()
    {
        // ����Ű �Է�
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // �̵� ���� ���
        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;

        // ������Ʈ �̵�
        transform.Translate(move, Space.World);

        switch(state)
        {
            case State.WALK: Walk();
                break;
            case State.ATTACK: Attack();
                break;
            case State.DIE: Die();
                break;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // ���� ������Ʈ�� �������� �浹 ���϶� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionExit(Collision collision)
    {
        // ���ӿ�����Ʈ�� �������� �浹���� ����� �� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浹�� ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("ontrigger enter");
    }
    private void OnTriggerStay(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浿 ���� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("ontrigger stay");

    }

    private void OnTriggerExit(Collider other)
    {
        // ���� ������Ʈ�� ���������� ���� �浹�� ����� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("ontrigger exit");

    }

    public void Walk()
    {
        Debug.Log("Walk");
    }

    public void Attack()
    {
        Debug.Log("Attack");
    }

    public void Die()
    {
        Debug.Log("Die");
    }


}
