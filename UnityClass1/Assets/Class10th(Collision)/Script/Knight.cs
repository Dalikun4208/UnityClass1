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

    public float moveSpeed = 5f; // 이동 속도

    void Update()
    {
        // 방향키 입력
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // 이동 벡터 계산
        Vector3 move = new Vector3(moveX, 0f, moveZ) * moveSpeed * Time.deltaTime;

        // 오브젝트 이동
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
        // 게임 오브젝트가 물리적인 충돌 중일때 호출되는 이벤트 함수.
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionExit(Collision collision)
    {
        // 게임오브젝트가 물리적인 충돌에서 벗어났을 때 호출되는 이벤트 함수.
        Debug.Log("OnCollisionExit");
    }

    private void OnTriggerEnter(Collider other)
    {
        // 게임 오브젝트가 물리적이지 않은 충돌을 했을 때 호출되는 이벤트 함수
        Debug.Log("ontrigger enter");
    }
    private void OnTriggerStay(Collider other)
    {
        // 게임 오브젝트가 물리적이지 않은 충동 중일 때 호출되는 이벤트 함수
        Debug.Log("ontrigger stay");

    }

    private void OnTriggerExit(Collider other)
    {
        // 게임 오브젝트가 물리적이지 않을 충돌이 벗어났을 때 호출되는 이벤트 함수
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
