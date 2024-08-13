using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class Monster : MonoBehaviour
{
    [SerializeField] Move move;
    int x, y, z = 1;
    private void Awake()
    {
        move = GetComponent<Move>();
    }
    void Start()
    {
        move.OnMove(new Vector3(1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            move.OnMove(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(Vector3.right);
        }
    }
}

