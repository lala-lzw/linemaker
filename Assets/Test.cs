﻿
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
 
public class Test : MonoBehaviour
{
    /// 

    /// 鼠标画图功能  
    ///   
    private GameObject clone;
    private LineRenderer line;
    public Camera asd;
    private int i;
    public GameObject tf;
    void Start()
    {

    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            clone = (GameObject)Instantiate(tf, tf.transform.position, transform.rotation);//克隆一个带有LineRender的物体  
            //clone.gameObject.GetComponent().enabled=false;  
            //clone.GetComponent().enabled=true;  
            line = clone.GetComponent<LineRenderer>();//获得该物体上的LineRender组件  
            line.SetColors(Color.blue, Color.red);//设置颜色  
            line.SetWidth(0.2f, 0.1f);//设置宽度  
            i = 0;
        }
        if (Input.GetMouseButton(0))
        {
            
            i++;
            line.SetVertexCount(i);//设置顶点数  
            line.SetPosition(i - 1, asd.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 15)));//设置顶点位置  
            //line.enabled=false;  
        }
    }
}