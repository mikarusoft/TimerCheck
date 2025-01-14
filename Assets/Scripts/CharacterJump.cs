using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterJump : MonoBehaviour
{
    [Header("Jump Settings")]
    public float jumpForce = 4f;
    public float jumpInterval = 0.3f; // ジャンプ間隔（秒）

    private Rigidbody rb;
    private bool isGrounded = true;
    private float jumpTimer = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGrounded)
        {
            jumpTimer += Time.deltaTime;
            if (jumpTimer >= jumpInterval)
            {
                Jump();
                jumpTimer = 0f;
            }
        }
        else
        {
            jumpTimer = 0f; // 接地していない間はタイマーをリセット
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
    }

    // 地面判定 (タグ "Ground" を想定)
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

