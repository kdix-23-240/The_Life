using UnityEngine;

public class Ball : IHitable
{
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;

    public Ball(GameObject gameObject)
    {
        _gameObject = gameObject;
        _rigidbody = _gameObject.GetComponent<Rigidbody2D>();
    }
    public void Hit(Collider2D other)
    {
        // Ballの角度とBallの角度から反射ベクトルを計算
        Vector2 normal = other.transform.up; // Ballの法線ベクトル
        Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
        Vector2 reflection = Vector2.Reflect(incoming, normal); // 反射ベクトル
        _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
    }
}