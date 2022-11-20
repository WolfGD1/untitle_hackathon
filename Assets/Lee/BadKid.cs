using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadKid : MonoBehaviour
{
    public float movePower = 1f;
    public float jumpPower = 1f;
    Vector3 moveVelocity = Vector3.zero;

    Rigidbody2D rigid;
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        moveVelocity = Vector3.zero;
    }
    private void Update()
    {
        //�������� moveVelocity�� �ٲ��ָ� �˾Ƽ� �����Դϴ�
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Santa"))
        {
            GameManager.Player1Score = 0; // ���� �÷��̾� 1 (������) ���� ������ �ٲ��ּ���
            Debug.Log(GameManager.Player1Score);
        }
        if (collision.gameObject.CompareTag("Santa2"))
        {
            GameManager.Player2Score = 0; // ���� �÷��̾� 2 (�ʷϻ�) ���� ������ �ٲ��ּ���
            Debug.Log(GameManager.Player2Score);
        }
        //UI�� ���� ���ھ� ��� �� �ְ� �ٲ��ּ���̤�
    }
}
