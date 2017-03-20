using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : MonoBehaviour
{

    private Animator _animator;
    private CanvasGroup _canvasGroup;

    public GameManager.GameState State;

    public bool IsOpen
    {
        get { return _animator.GetBool("IsOpen"); }
        set { _animator.SetBool("IsOpen", value); }
    }

	// Use this for initialization
	void Awake ()
	{
	    _animator = GetComponent<Animator>();
	    _canvasGroup = GetComponent<CanvasGroup>();

	    var transform = GetComponent<RectTransform>();
	    transform.offsetMax = transform.offsetMin = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Fade In"))
	    {
	        _canvasGroup.blocksRaycasts = _canvasGroup.interactable = true;
	    }
	    else
	    {
	        _canvasGroup.blocksRaycasts = _canvasGroup.interactable = false;
	    }
	}
}
