using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // UnityEvent�� ����ϱ� ���� �߰�

public class BilliardBall : MonoBehaviour
{
    [SerializeField] UnityEvent callback; // UnityEvent�� ����

    private void Start()
    {
        if (callback != null)
        {
            callback.Invoke(); // UnityEvent�� Invoke �޼��� ���
        }
    }
}