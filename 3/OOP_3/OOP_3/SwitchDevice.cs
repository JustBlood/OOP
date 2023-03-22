using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class SwitchDevice
    {
        public Switch DeviceSwitch { get; set; }

        public SwitchDevice()
        {
            DeviceSwitch = new Switch();
        }

        public void Step1()
        {
            DeviceSwitch.DisconnectPowerGenerator();
        }

        public void Step2()
        {
            DeviceSwitch.VerifyPrimaryCoolantSystem();
        }

        public void Step3()
        {
            DeviceSwitch.VerifyBackupCoolantSystem();
        }

        public void Step4()
        {
            DeviceSwitch.GetCoreTemperature();
        }

        public void Step5()
        {
            DeviceSwitch.InsertRodCluster();
        }

        public void Step6()
        {
            DeviceSwitch.GetCoreTemperature();
        }

        public void Step7()
        {
            DeviceSwitch.GetRadiationLevel();
        }

        public void Step8()
        {
            DeviceSwitch.SignalShutdownComplete();
        }
    }
}
