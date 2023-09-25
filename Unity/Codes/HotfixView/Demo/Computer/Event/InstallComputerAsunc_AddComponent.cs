using ET.EventType;

namespace ET
{
    public class InstallComputerAsunc_AddComponent : AEventAsync<EventType.InstallComputerAsync>
    {
        protected async override ETTask Run(InstallComputerAsync arg)
        {
            Computer computer = arg.Computer;
            computer.AddComponent<PCCaseComponent>();
            computer.AddComponent<MonitorsComponent>();
            computer.AddComponent<MouseCommponent>();
            computer.AddComponent<KeyboardComponent>();

            await TimerComponent.Instance.WaitAsync(3000);
            
            computer.Start();
        }
    }
} 