﻿namespace ET
{
    public class ComputerAwakeSystem: AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("ComputerAwake!!!!!!!!!");
        }
    }

    public class ComputerUpdateSystem: UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("ComputerUpdate!!!!!!!!");
        }
    }
    
    public class ComputerDestorySystem: DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("ComputerDestory!!!!!!!!");
        }
    }
    
    public static class ComputerSystem
    {
        public static void Start(this Computer self)
        {
            Log.Debug("Computer Start");
            self.GetComponent<PCCaseComponent>().StartPower();
            self.GetComponent<MonitorsComponent>().Display();

        }
    }
}