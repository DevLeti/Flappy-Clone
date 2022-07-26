using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower; // public으로 unity에서도 접근 가능하도록 설정 가능
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { // 0이 마우스 왼쪽 버튼
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // (0, 3)
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore) {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}