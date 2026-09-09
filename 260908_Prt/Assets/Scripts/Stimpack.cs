using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stimpack : MonoBehaviour, IInteractable
{
    public GameObject GameObject { get => gameObject; }
    private Outline _outline;
    [SerializeField] private float _buffMoveSpeed;
    [SerializeField] private float _buffDuration;

    //rivate float _currentRemainTime;

    //private bool _isBuffFinish => _currentRemainTime >= _buffDuration;
    //private bool _isStimpackActivated = false;

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
        //UpdateTime();
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
    }

    public void Interact(IInteractor owner)
    {
        if (!(owner is PlayerController))
            return;

        PlayerController player = (PlayerController)owner;
        PlayerMovement move = player.GetComponent<PlayerMovement>();
        
        if(move != null)
        {
            StimpackBuff buff = player.gameObject.AddComponent<StimpackBuff>();
            buff.ApplyBuff(move, _buffMoveSpeed, _buffDuration);
        }

        Destroy(gameObject);
    }

    //private void UpdateTime()
    //{
    //    if (!_isStimpackActivated)
    //        return;

    //    _currentRemainTime += Time.deltaTime;
    //}
}