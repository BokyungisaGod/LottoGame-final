using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    private Animator animator;
    public Animator fadeOut;

    private void Start()
    {
        // ���� ������Ʈ�� ����� Animator ������Ʈ ��������
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // ���� ��� ���� �ִϸ��̼��� ���� ��������
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // �ִϸ��̼��� �������� Ȯ��
        if (stateInfo.normalizedTime >= 1f)
        {
            // �ִϸ��̼��� �� �������� ó��
            fadeOut.SetTrigger("On");
            Invoke("SceneChange", 4f);
        }
    }
    private void SceneChange() 
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
    