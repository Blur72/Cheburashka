using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    private Transform _player;

    [SerializeField] private float _movespeed; 
    [SerializeField] private float _movestep; 
    private bool _isPause = false;

    private UIElements _UIElements;

    private void Awake()
    {
        _player = GetComponent<Transform>();
    }

    private void Update()
    {
        float mss = _movespeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            _player.position = Vector2.MoveTowards(_player.position, new Vector2(_player.position.x, _player.position.y + _movestep), mss);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _player.position = Vector2.MoveTowards(_player.position, new Vector2(_player.position.x - _movestep, _player.position.y), mss);
            FlipPlayer(1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _player.position = Vector2.MoveTowards(_player.position, new Vector2(_player.position.x, _player.position.y - _movestep), mss);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _player.position = Vector2.MoveTowards(_player.position, new Vector2(_player.position.x + _movestep, _player.position.y), mss);
            FlipPlayer(-1);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            _isPause = !_isPause;
            Time.timeScale = _isPause ? 0 : 1;
        }
    }

    private void FlipPlayer(int direction)
    {
        Vector3 scale = _player.localScale;
        scale.x = 0.3f * direction; 
        _player.localScale = scale;
    }
}