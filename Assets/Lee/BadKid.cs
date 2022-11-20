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
        //랜덤으로 moveVelocity만 바꿔주면 알아서 움직입니당
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Santa"))
        {
            GameManager.Player1Score = 0; // 여기 플레이어 1 (빨간색) 현재 선물로 바꿔주세요
            Debug.Log(GameManager.Player1Score);
        }
        if (collision.gameObject.CompareTag("Santa2"))
        {
            GameManager.Player2Score = 0; // 여기 플레이어 2 (초록색) 현재 선물로 바꿔주세요
            Debug.Log(GameManager.Player2Score);
        }
        //UI로 현재 스코어 띄울 수 있게 바꿔주세요ㅜㅜ
    }
}
