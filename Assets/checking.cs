using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checking : MonoBehaviour
{
    void Update()
    {
        // ���콺 ��ư�� Ŭ���Ǿ����� Ȯ��
        if (Input.GetMouseButtonDown(0))
        {
            // ���콺�� Ŭ���� ��ġ���� Ray�� �߻�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Ray�� � ������Ʈ�� �浹�ߴ��� Ȯ��
            if (Physics.Raycast(ray, out hit))
            {
                // �浹�� ������Ʈ�� �̸��� ���
                Debug.Log("Clicked Object Name: " + hit.collider.gameObject.name);
            }
        }
    }
}
