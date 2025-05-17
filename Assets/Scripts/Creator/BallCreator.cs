using UnityEngine;
using Cysharp.Threading.Tasks;

public class BallCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] _balls;
    [SerializeField] private float _createDelayTime = 5f;

    async UniTask Start()
    {
        while (true)
        {
            Create();
            await UniTask.Delay((int)(_createDelayTime * 1000));
        }
    }

    private void Create()
    {
        Instantiate(_balls[Random.Range(0, _balls.Length)], this.gameObject.transform);
    }
}