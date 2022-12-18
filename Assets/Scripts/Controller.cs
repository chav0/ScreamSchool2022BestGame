using UnityEngine;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
	public RectTransform background;
	public RectTransform stick;
	public float maxStickOffset; 
	public float minPointerOffset; 

	private Vector2 _offset;
	private Model _model; 

	public void Init(Model model)
	{
		_model = model; 
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}
	
	public void OnDrag(PointerEventData eventData)
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle(
			background,
			eventData.position,
			eventData.pressEventCamera,
			out _offset);

		var stickOffset = _offset.magnitude;
		stick.anchoredPosition = stickOffset > maxStickOffset
			? maxStickOffset / stickOffset * _offset
			: _offset;
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		_model.Input.CreateProjectile = true; 
		stick.anchoredPosition = Vector2.zero;
		_offset = Vector2.zero;
	}
	
	private void Update()
	{
		var isAiming = _offset.magnitude >= minPointerOffset;
		_model.Input.IsAiming = isAiming; 
		if (!isAiming)
			return;

		var angle = 270 - Mathf.Rad2Deg * Mathf.Atan2(_offset.y, _offset.x);
		var forceRatio = Mathf.Clamp01((_offset.magnitude - minPointerOffset) / (maxStickOffset - minPointerOffset));
		
		_model.Input.Angle = angle;
		_model.Input.ForceRatio = forceRatio; 
	}
}
