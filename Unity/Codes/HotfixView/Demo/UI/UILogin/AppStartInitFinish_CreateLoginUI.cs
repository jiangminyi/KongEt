

using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async void Run(EventType.AppStartInitFinish args)
		{
			UIHelper.Create(args.ZoneScene, UIType.UILogin, UILayer.Mid).Coroutine();

            Computer computer = args.ZoneScene.AddChild<Computer>();
            
            Log.Debug("AAA");
			//this.TestAsync().Coroutine();
			int result = await this.TestResultAsync(); 
            Log.Debug("BBB");
            //Game.EventSystem.Publish(new EventType.InstallComputer(){Computer = computer});

            //Game.EventSystem.PublishAsync(new EventType.InstallComputerAsync() { Computer = computer }).Coroutine();

            //computer.Start();
            // computer.AddComponent<PCCaseComponent>();
            // computer.AddComponent<MonitorsComponent>();
            // computer.AddComponent<KeyboardComponent>();
            // computer.AddComponent<MouseCommponent>();
            //
            // computer.Start();
            //
            // computer.Dispose();
            //Test(args.ZoneScene).Coroutine();
		}

		public async ETTask TestAsync()
		{
			//await ETTask.CompletedTask;
			Log.Debug("1111111111111111111111111111111111");
			await TimerComponent.Instance.WaitAsync(2000);
			Log.Debug("2222222222222222222222222222222222");
		}
		
		public async ETTask<int> TestResultAsync()
		{
			//await ETTask.CompletedTask;
			Log.Debug("1111111111111111111111111111111111");
			await TimerComponent.Instance.WaitAsync(2000);
			Log.Debug("2222222222222222222222222222222222");
			return 5;
		}

		public async ETTask Test(Scene zoneScene)
		{
			//Computer computer = zoneScene.AddChild<Computer>();
			await ETTask.CompletedTask;
			// computer.AddComponent<PCCaseComponent>();
			// computer.AddComponent<MonitorsComponent>();
			// computer.AddComponent<KeyboardComponent>();
			// computer.AddComponent<MouseCommponent>();
			//
			// computer.Start();
			// await TimerComponent.Instance.WaitAsync(3000);
			// computer.Dispose();
			//
			// UnitConfig config = UnitConfigCategory.Instance.Get(1001);
			//
			// Debug.Log(config.Name);
			//
			// var allUnityConfig = UnitConfigCategory.Instance.GetAll();
			//
			// foreach (var cf in allUnityConfig.Values)
			// {
			// 	Debug.Log("aaa"+cf.Name);
			// 	Debug.Log("Vector3"+cf.TestValue);
			// }
			//
			// UnitConfig heightConfig = UnitConfigCategory.Instance.GetUnitConfigByHeight(178);
			//
			// Debug.Log(config.Name);
		}
	}
}
