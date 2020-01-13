using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private Transform[] positionsRandom;
    [SerializeField] private Transform positionDefault;
    [SerializeField] private Transform ball;

    void Start()
    {
        ball.position = positionDefault.position;
    }

    public void Move()
    {
        Vector3 oldPos;
        Vector3 newPos;

        oldPos = ball.position;
        newPos = positionsRandom[Random.Range(0, positionsRandom.Length)].position;
        ball.position = newPos;
    }
}
