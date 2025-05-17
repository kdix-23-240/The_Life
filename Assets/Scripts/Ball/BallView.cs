using UnityEngine;

public class BallView : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public void Initialize()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
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
    /// <summary>
    /// 雑に書きすぎているので、後で修正する
    /// コリジョンインターフェース的なものを作って別のクラスに処理を書く
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        IHitable hit;
        switch (other.tag)
        {
            case "Ball":
                hit = new Ball(gameObject);
                hit.Hit(other);
                break;
            case "CenterStage":
                hit = new CenterStage(gameObject);
                hit.Hit(other);
                break;
            case "FrameHorizon":
                hit = new FrameHorizon(gameObject);
                hit.Hit(other);
                break;
            case "FrameVertical":
                hit = new FrameVertical(gameObject);
                hit.Hit(other);
                break;
            case "GameOver":
                hit = new GameOver(gameObject);
                hit.Hit(other);
                break;
            case "Stage":
                hit = new Stage(gameObject);
                hit.Hit(other);
                break;
            default:
                Debug.Log("予期せぬ当たり判定 : " + other.tag);
                break;
        }
    }
}