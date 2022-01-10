using System.Collections.Generic;
using UnityEngine;

namespace Services.Injection
{
	public class RuntimeInjector : MonoBehaviour
	{
		[SerializeField] private GameObject[] injectionObjects;
		[SerializeField] private Injector injector;
		
		public void Setup()
		{
			List<IInjectionObject> iObj = new List<IInjectionObject>();

			foreach (GameObject obj in injectionObjects)
			{
				IInjectionObject[] injectables = obj.GetComponents<IInjectionObject>();
				if(injectables == null || injectables.Length == 0) continue;
				
				foreach (IInjectionObject injectable in injectables)
				{
					iObj.Add(injectable);
				}
			}
			
			injector.Setup(iObj);
		}
		
		public void AddInjectionObject(IInjectionObject injectionObject)
		{
			injector.AddInjectionObject(injectionObject);
		}
	}
}