using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrab : MonoBehaviour
{
    public Animator anim;
    // �̵� �ӵ�
    public float speed = 20f; // �̵��� �ӵ��� �����ϰ� �����ϼ���.

    // ��ǥ x ��ǥ
    public float targetX = 800f;
    // Start is called before the first frame update
    // RectTransform ������Ʈ
    private RectTransform rectTransform;
    void Start()
    {
        anim = GetComponent<Animator>();
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame

    public void Move()
    {
        anim.SetTrigger("On");
        
    }
}
    


