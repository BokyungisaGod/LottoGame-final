using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed ;
    private bool isTouchLeft;
    private bool isTouchRight;
    private bool isTouchUp;
    private bool isTouchDown;
    public MoveCamera mainCamera;
    // Update is called once per frame
    void FixedUpdate()
    {
        Move(); 
    }
    public void Move() 
    {
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKey(KeyCode.LeftArrow)&&!isTouchLeft)
        {
            transform.Translate(-speed, 0, 0); // �������� ��3�� �����δ�
        }
        else if (Input.GetKey(KeyCode.RightArrow)&&!isTouchRight)
        {
            transform.Translate(speed, 0, 0); // ���������� ��3�� �����δ�
        }
        else if (Input.GetKey(KeyCode.UpArrow) && !isTouchUp)
        {
            transform.Translate(0, speed, 0); // ���������� ��3�� �����δ�
        }
        else if (Input.GetKey(KeyCode.DownArrow) && !isTouchDown)
        {
            transform.Translate(0, -speed, 0); // ���������� ��3�� �����δ�
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Right":
                    isTouchRight = true;
                    break;
                case "Left":
                    isTouchLeft = true;
                    break;
                case "Up":
                    isTouchUp = true;
                    break;
                case "Down":
                    isTouchDown = true;
                    break;

            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            switch (collision.gameObject.name)
            {
                case "Right":
                    isTouchRight = false;
                    break;
                case "Left":
                    isTouchLeft = false;
                    break;
                case "Up":
                    isTouchUp = false;
                    break;
                case "Down":
                    isTouchDown = false;
                    break;


            }
        }
    }

}

