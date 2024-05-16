using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBubble : MonoBehaviour
{
    Rigidbody2D rigid;
    float speed = 2f;
    Vector2 moveDirection; // �ʱ� �̵� ����
    AudioManager audiomanager;

    void Start()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        rigid = GetComponent<Rigidbody2D>();

        // ������ �ʱ� �̵� ���� ����
        float randomAngle = Random.Range(0f, 360f);
        moveDirection = Quaternion.Euler(0, 0, randomAngle) * Vector2.up;
    }

    // Update is called once per frame
    void Update()
    {
        // �񴰹���� �̵�
        rigid.velocity = moveDirection * speed;
    }

    // �浹 �̺�Ʈ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audiomanager.PlaySFX(audiomanager.Bubble);
        // �浹�� �� �񴰹���� ��ġ ���̸� ����Ͽ� ���� ���ͷ� ���
        Vector2 direction = (collision.transform.position - transform.position).normalized;
        moveDirection = -direction; // �ݴ� �������� ����
    }
}
