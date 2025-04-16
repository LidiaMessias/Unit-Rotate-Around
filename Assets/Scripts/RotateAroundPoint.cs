using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Transform pointToRotateAround;
    public Vector3 rotationAxis = Vector3.up;
    public float rotationSpeed = 150f;

    void Update()
    {
        if (pointToRotateAround != null)
        {
            transform.RotateAround(pointToRotateAround.position, rotationAxis, rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogError("O ponto de rotação não foi atribuído no Inspector!");
        }
    }
}
