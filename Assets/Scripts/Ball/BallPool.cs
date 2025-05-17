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

    private IEnumerator DelayDeactivation(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Deactivate();
    }

    public void Deactivate()
    {
        Debug.Log("ボールを非アクティブにします");
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = Vector2.zero;
        rigidbody.angularVelocity = 0f;
        _objectPool.Release(this);
    }
}