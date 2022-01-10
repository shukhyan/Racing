using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Services.Injection
{
	public class Injector : ScriptableObject
	{
		[SerializeField] private GameObject[] injectionObjects;
		[SerializeField] private ScriptableObject[] injectionScriptableObjects;
		
		private Dictionary<string, IInjectionObject> _injectionObjects;

		public void Setup(List<IInjectionObject> injectionObjects)
		{
			if(_injectionObjects == null) _injectionObjects = new Dictionary<string, IInjectionObject>();
			_injectionObjects.Clear();
			
			foreach (IInjectionObject injectable in injectionObjects)
			{
				_injectionObjects.Add(injectable.GetType().Name, injectable);
			}
			
			foreach (ScriptableObject injectionSO in injectionScriptableObjects)
			{
				if(injectionSO is IInjectionObject injectable)
				{
					_injectionObjects.Add(injectable.GetType().Name, injectable);
				}
			}

		}

		public void AddInjectionObject(IInjectionObject injectionObject)
		{
			if(_injectionObjects == null) _injectionObjects = new Dictionary<string, IInjectionObject>();
			_injectionObjects.Add(injectionObject.GetType().Name, injectionObject);
		}

		public T GetInjectionObject<T>() where T : class, IInjectionObject
		{
			if (!_injectionObjects.ContainsKey(typeof(T).Name))
			{
				Debug.LogError($"{typeof(T).Name} :: Object isn't injected!");
				return null;
			}
			IInjectionObject iObj = _injectionObjects[typeof(T).Name];
			

			T obj  = iObj as T;

			if(obj == null) Debug.LogError($"Please Inject {typeof(T).Name} before using!");
			return obj;
		}
	}
}