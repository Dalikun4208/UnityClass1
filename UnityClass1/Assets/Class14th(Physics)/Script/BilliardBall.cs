using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // UnityEvent를 사용하기 위해 추가

public class BilliardBall : MonoBehaviour
{
    [SerializeField] UnityEvent callback; // UnityEvent로 수정

    private void Start()
    {
        if (callback != null)
        {
            callback.Invoke(); // UnityEvent의 Invoke 메서드 사용
        }
    }
}