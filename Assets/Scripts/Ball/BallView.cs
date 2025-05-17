using UnityEngine;

public class BallView : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public void Initialize()
    {
        Debug.Log("Initializing BallView...");
        _rigidbody = GetComponent<Rigidbody2D>();
        if (_rigidbody == null)
        {
            Debug.LogError("Rigidbody2Dがアタッチされていません: " + gameObject.name);
        }
    }
    public void MoveX(float x)
    {
        Vector3 newPosition = this.transform.position;
        newPosition.x = x;
        this.transform.position = newPosition;
    }
    public void MoveY(float y)
    {
        Vector3 newPosition = this.transform.position;
        newPosition.y = y;
        this.transform.position = newPosition;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stage")
        || other.CompareTag(""))
        {
            // Stageの角度とBallの角度から反射ベクトルを計算
            Vector2 normal = other.transform.up; // Stageの法線ベクトル
            Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
            Vector2 reflection = Vector2.Reflect(incoming, normal); // 反射ベクトル
            _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
        }
    }
}