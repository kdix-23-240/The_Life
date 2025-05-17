using UnityEngine;

public class BallView : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public void Initialize()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(float x)
    {
        Vector3 newPosition = this.transform.position;
        newPosition.x = x;
        this.transform.position = newPosition;
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Stage"))
        {
            // Stageの角度とBallの角度から反射ベクトルを計算
            Vector2 stageNormal = other.transform.up;
            Vector2 ballVelocity = _rigidbody.linearVelocity;
            Vector2 reflection = Vector2.Reflect(ballVelocity, stageNormal);
        }
    }
}