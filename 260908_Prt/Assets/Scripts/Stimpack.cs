using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stimpack : MonoBehaviour, IInteractable
{
    public GameObject GameObject { get => gameObject; }
    private Outline _outline;
    [SerializeField] private float _buffMoveSpeed;
    [SerializeField] private float _buffDuration;

    private float _currentRemainTime;

    private bool _isBuffFinish => _currentRemainTime >= _buffDuration; 

    private void Awake()
    {
        CacheComponents();
    }
    private void Start()
    {
        Init();
    }

    private void Update()
    {
        UpdateTime();
    }

    public void Targeting()
    {
        _outline.enabled = true;
    }

    public void Untargeting()
    {
        _outline.enabled = false;
    }

    private void CacheComponents()
    {
        _outline = gameObject.GetComponent<Outline>();
    }

    private void Init()
    {
        _outline.enabled = false;
        _currentRemainTime = _buffDuration;
    }

    public void Interact(IInteractor owner)
    {

        if (!(owner is PlayerController))
            return;

        PlayerController player = (PlayerController)owner;

        Destroy(gameObject);
    }

    private void UpdateTime()
    {
        if (_isBuffFinish)
            return;

        _currentRemainTime += Time.deltaTime;
    }
}
