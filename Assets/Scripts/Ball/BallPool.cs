using System.Collections;
using UnityEngine;
using UnityEngine.Pool;

public class BallPool : MonoBehaviour, IPooledObject<BallPool>
{
    private IObjectPool<BallPool> _objectPool;
    [SerializeField] private float _lifetime = 5f;
    public IObjectPool<BallPool> ObjectPool
    {
        set => _objectPool = value;
    }

    public void Initialize()
    {
        StartCoroutine(DelayDeactivation(_lifetime));
    }

    /// <summary>
    /// ボールの生存時間を設定する
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns></returns>
    private IEnumerator DelayDeactivation(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Deactivate();
    }

    /// <summary>
    /// ボールをプールに戻す
    /// 非表示にする
    /// </summary>
    public void Deactivate()
    {
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = Vector2.zero;
        rigidbody.angularVelocity = 0f;
        _objectPool.Release(this);
    }
}