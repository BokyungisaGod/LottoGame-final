using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game1 : MonoBehaviour
{
    public Animator start;
    public Animator target1;
    public Animator target2;
    public Animator target3;
    public Animator target4;
    public Animator target5;
    public string triName;
    private bool check = false;
    private void Start()
    {

    }

    private void Update()
    {
        // ���� ��� ���� �ִϸ��̼��� ���� ��������
        AnimatorStateInfo stateInfo = start.GetCurrentAnimatorStateInfo(0);

        // �ִϸ��̼��� �������� Ȯ��
        if (stateInfo.normalizedTime >= 1f&&check==false)
        {
            // �ִϸ��̼��� �� �������� ó��
            target1.SetTrigger(triName);
            target2.SetTrigger(triName);
            target3.SetTrigger(triName);
            check = true;
            Invoke("nextAnim", 4f);
        }
    }
    private void nextAnim() 
    {
        target4.SetTrigger("On");
        target5.SetTrigger("Move");
    }
}
