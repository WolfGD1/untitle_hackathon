using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodKid : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Santa"))
        {
            GameManager.Player1Score += 5; // ���� �÷��̾� 1 (������) ���� ������ �ٲ��ּ���
            Debug.Log(GameManager.Player1Score);
        }
        if (collision.gameObject.CompareTag("Santa2"))
        {
            GameManager.Player2Score += 5; // ���� �÷��̾� 2 (�ʷϻ�) ���� ������ �ٲ��ּ���
            Debug.Log(GameManager.Player2Score);
        }
        //UI�� ���� ���ھ� ��� �� �ְ� �ٲ��ּ���̤�
    }
}
