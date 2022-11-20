using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodKid : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Santa"))
        {
            GameManager.Player1Score += 5; // 여기 플레이어 1 (빨간색) 현재 선물로 바꿔주세요
            Debug.Log(GameManager.Player1Score);
        }
        if (collision.gameObject.CompareTag("Santa2"))
        {
            GameManager.Player2Score += 5; // 여기 플레이어 2 (초록색) 현재 선물로 바꿔주세요
            Debug.Log(GameManager.Player2Score);
        }
        //UI로 현재 스코어 띄울 수 있게 바꿔주세요ㅜㅜ
    }
}
