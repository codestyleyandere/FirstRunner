using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _movespeed;
    [SerializeField] private float _stepsize;
    [SerializeField] private float _minheight;
    [SerializeField] private float _maxheight;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }
    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position,_targetPosition,_movespeed * Time.deltaTime);
    }
    
    public void MoveUp()
    {
        if (_targetPosition.y < _maxheight)
        SetNextPosition(_stepsize);
    }
    public void MoveDown()
    {
        if(_targetPosition.y > _minheight)
        SetNextPosition(-_stepsize);
    }
    private void SetNextPosition(float stepsize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepsize);
    }
}
