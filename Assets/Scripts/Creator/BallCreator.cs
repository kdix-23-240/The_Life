using UnityEngine;
using Cysharp.Threading.Tasks;

/// <summary>
/// ボールを生成するクラス
/// </summary>
public class BallCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] _balls;
    [SerializeField] private float _createDelayTime = 5f;// 生成間隔(秒)

    async UniTask Start()
    {
        while (true)
        {
            Create();
            // _createDelayTime 秒の遅延
            await UniTask.Delay((int)(_createDelayTime * 1000));
        }
    }
    /// <summary>
    /// ボールを生成する
    /// </summary>
    private void Create()
    {
        Instantiate(_balls[Random.Range(0, _balls.Length)], this.gameObject.transform);
    }
}