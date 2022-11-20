using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float resettimer = 5;
    float timer;
    bool spawner = false;
    private int order = 0;
    public GameObject giftblue;
    public GameObject giftred;
    public GameObject giftyellow;
    void Start()
    {
        int a = Random.Range(0, 10);
        timer = resettimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            
            spawn();
            order++;
            timer = resettimer;
        }
    }
    void TimerReset() {//산타가 획득시 타이머 리셋
    }
    void spawn() {
        Vector2 position = new Vector2(Random.Range(-9, 9), Random.Range(-3, 3));//random()
        if (order%3 == 0)
        {
            Instantiate(giftblue, position, Quaternion.identity);
        }
        else if(order %3 == 1)
        {
            Instantiate(giftred, position, Quaternion.identity);
        }
        else
        {
            Instantiate(giftyellow, position, Quaternion.identity);
        }
    }
}
