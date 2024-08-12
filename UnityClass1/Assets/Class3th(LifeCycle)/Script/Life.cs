using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    private void Awake()
    {
        // 어 웨이크 함수는 게임 오브젝트가 생성되었을 때 , 단 한번만 호출되며
        // 스크립트가 비활성화 된 상태일때도 호출되는 이벤트 함수입니다.
        Debug.Log("awake");
    }

    private void OnEnable()
    {
        // 이 함수는 게임 오브젝트가 활성화 되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("onenable");
    }

    // Start is called before the first frame update
    void Start()
    {
        // 태어났을때 : 1번
        // 살아있는 동안 : 매 프레임마다
        // 죽었을 때 : 1번
        // 초기화 > 물리 > 업데이트 > 해제
        // 이 함수는 게임 오브젝트가 생성되었을 떄, 단 한번만 호출되며,
        // 스크립트가 비활성화된 상태일 땐, 호출되지 않는 이벤트 함수입니다.
        Debug.Log("start");

    }

    private void FixedUpdate()
    {
        // 0.02초 간격
        // 키 입력을 넣고 반응하는게 여기에 들어갈것
        // timestep이라는 값에 따라 일정한 간격으로 호출되는 이벤트함수입니다.
        Debug.Log("fixedupdate");
    }

    // Update is called once per frame
    void Update()
    {
        //update()
        // 프레임마다 호출되는 이벤트 함수입니다.
        Debug.Log("update");

    }

    private void LateUpdate()
    {
        // lateupdate()
        // update 함수가 끝난 후에 호출되는 이벤트 함수입니다.
        Debug.Log("LateUpdate");
        // 따라다니는 카메라, 카메라 연출관련으로 사용됨.
    }

    private void OnDisable()
    {
        //게임오브젝트가 비활성화 되었을 때 호출되는 이벤트 함수입니다.
        Debug.Log("OnDisable");

    }

    private void OnDestroy()
    {
        // 게임 오브젝트가 파괴되었을때 호출되는 이벤트 함수입니다.
        Debug.Log("OnDestroy");

    }

}
