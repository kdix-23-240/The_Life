using UnityEngine;

public class CenterStage : IHitable
{
    private GameObject _gameObject;
    private Rigidbody2D _rigidbody;

    public CenterStage(GameObject gameObject)
    {
        _gameObject = gameObject;
        _rigidbody = _gameObject.GetComponent<Rigidbody2D>();
    }
    public void Hit(Collider2D other)
    {
        // y軸方向の速度を0にする
        Vector2 velocity = _rigidbody.linearVelocity;
        velocity.y = 0;
        _rigidbody.linearVelocity = velocity;

        // y軸方向に力を加える
        Vector2 force = new Vector2(0, 20f); // 上方向の力
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}