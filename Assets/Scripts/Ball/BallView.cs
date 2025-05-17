using UnityEngine;

public class BallView : MonoBehaviour
{
    [SerializeField] private float _reflectPlusRate = 1.05f; // 反射率
    [SerializeField] private float _reflectMinusRate = 0.5f; // 反射率
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
        Debug.Log("tag:" + other.tag);

        if (other.CompareTag("Stage"))
        {
            // Stageの角度とBallの角度から反射ベクトルを計算
            Vector2 normal = other.transform.up; // Stageの法線ベクトル
            Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
            Vector2 reflection = Vector2.Reflect(incoming * _reflectPlusRate, normal); // 反射ベクトル
            _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
        }

        if (other.CompareTag("Ball"))
        {
            // Ballの角度とBallの角度から反射ベクトルを計算
            Vector2 normal = other.transform.up; // Ballの法線ベクトル
            Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
            Vector2 reflection = Vector2.Reflect(incoming, normal); // 反射ベクトル
            _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
        }

        if (other.CompareTag("FrameVertical"))
        {
            // FrameVerticalの角度とBallの角度から反射ベクトルを計算
            Vector2 normal = other.transform.right; // FrameVerticalの法線ベクトル
            Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
            Vector2 reflection = Vector2.Reflect(incoming * _reflectMinusRate, normal); // 反射ベクトル
            _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
        }
        
        if (other.CompareTag("FrameHorizon"))
        {
            // FrameHorizontalの角度とBallの角度から反射ベクトルを計算
            Vector2 normal = other.transform.up; // FrameHorizontalの法線ベクトル
            Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
            Vector2 reflection = Vector2.Reflect(incoming * _reflectMinusRate, normal); // 反射ベクトル
            _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
        }
    }
}