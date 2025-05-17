using UnityEngine;

/// <summary>
/// キーボード入力による操作を行うクラス
/// </summary>
public class KeyController : MonoBehaviour, IController
{
    [SerializeField] private float _speed = 1f;
    private float _maxX = 4.3f;
    /// <summary>
    /// キーボード入力による操作を行う
    /// </summary>
    public void Control()
    {
        // 左右の移動
        // 左端にいなければ、移動できる
        if (-_maxX < this.gameObject.transform.position.x)
        {
            if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.position += Vector3.left * _speed * Time.deltaTime;
            }
        }

        // 右に移動
        // 右端にいなければ、移動できる
        if (this.gameObject.transform.position.x < _maxX)
        {
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
            }
        }
    }
}