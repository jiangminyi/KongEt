using System;
using UnityEngine;

namespace ET
{
	public static class Entry
	{
		public static void Start()
		{
			try
			{
				CodeLoader.Instance.Update += Game.Update;
				CodeLoader.Instance.LateUpdate += Game.LateUpdate;
				CodeLoader.Instance.OnApplicationQuit += Game.Close;
				
				
				Game.EventSystem.Add(CodeLoader.Instance.GetHotfixTypes());

				
				Game.EventSystem.Publish(new EventType.AppStart());
				Debug.Log("项目开启");
			}
			catch (Exception e)
			{
				Log.Error(e);
			}
		}
	}
}