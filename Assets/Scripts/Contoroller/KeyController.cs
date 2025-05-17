using UnityEngine;

public class KeyController : MonoBehaviour, IController
{
    [SerializeField] private float _speed = 1f;
    public void Control(GameObject gameObject)
    {
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += Vector3.left * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Vector3.right * _speed * Time.deltaTime;
        }
    }
}