using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    private void Awake()
    {
        // �� ����ũ �Լ��� ���� ������Ʈ�� �����Ǿ��� �� , �� �ѹ��� ȣ��Ǹ�
        // ��ũ��Ʈ�� ��Ȱ��ȭ �� �����϶��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("awake");
    }

    private void OnEnable()
    {
        // �� �Լ��� ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("onenable");
    }

    // Start is called before the first frame update
    void Start()
    {
        // �¾���� : 1��
        // ����ִ� ���� : �� �����Ӹ���
        // �׾��� �� : 1��
        // �ʱ�ȭ > ���� > ������Ʈ > ����
        // �� �Լ��� ���� ������Ʈ�� �����Ǿ��� ��, �� �ѹ��� ȣ��Ǹ�,
        // ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ��, ȣ����� �ʴ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("start");

    }

    private void FixedUpdate()
    {
        // 0.02�� ����
        // Ű �Է��� �ְ� �����ϴ°� ���⿡ ����
        // timestep�̶�� ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ�Լ��Դϴ�.
        Debug.Log("fixedupdate");
    }

    // Update is called once per frame
    void Update()
    {
        //update()
        // �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("update");

    }

    private void LateUpdate()
    {
        // lateupdate()
        // update �Լ��� ���� �Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("LateUpdate");
        // ����ٴϴ� ī�޶�, ī�޶� ����������� ����.
    }

    private void OnDisable()
    {
        //���ӿ�����Ʈ�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDisable");

    }

    private void OnDestroy()
    {
        // ���� ������Ʈ�� �ı��Ǿ����� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.
        Debug.Log("OnDestroy");

    }

}
