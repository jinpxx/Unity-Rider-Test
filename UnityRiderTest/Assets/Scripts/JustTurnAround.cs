using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustTurnAround : MonoBehaviour
{
    public float speed = 2f; // 圆周运动的速度
    public float radius = 2f; // 圆周运动的半径
    public Vector3 center; // 圆周运动的中心点

    private float angle; // 当前角度

    private void Start()
    {
        // 将物体初始位置设置在圆周运动的起始点
        transform.position = new Vector3(center.x + radius, center.y, center.z);
    }

    private void Update()
    {
        // 根据速度更新角度
        angle += speed * Time.deltaTime;

        // 计算物体在圆周上的位置
        Vector3 newPos = new Vector3(Mathf.Cos(angle) * radius, center.y, Mathf.Sin(angle) * radius);

        // 将物体位置设置为圆周上的位置
        transform.position = newPos + center;
    }
}
