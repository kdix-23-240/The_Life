using UnityEngine;

public class StageView : MonoBehaviour
{
    public void Initialize()
    {
        
    }
    public void Move(float x)
    {
        Vector3 newPosition = this.transform.position;
        newPosition.x = x;
        this.transform.position = newPosition;
    }
}