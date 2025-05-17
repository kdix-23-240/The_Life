using UnityEngine;

public class Stage : IHitable
{
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;
    private float _reflectRate = 0.8f; // 反射率（プラス）

    public Stage(GameObject gameObject)
    {
        _gameObject = gameObject;
        _rigidbody = _gameObject.GetComponent<Rigidbody2D>();
    }
    public void Hit(Collider2D other)
    {
        // Stageの角度とBallの角度から反射ベクトルを計算
        Vector2 normal = other.transform.up; // Stageの法線ベクトル
        Vector2 incoming = _rigidbody.linearVelocity; // Ballの入射ベクトル（修正: linearVelocity → velocity）
        Vector2 reflection = Vector2.Reflect(incoming * _reflectRate, normal); // 反射ベクトル
        _rigidbody.linearVelocity = reflection; // Ballの速度を反射ベクトルに設定
    }
}