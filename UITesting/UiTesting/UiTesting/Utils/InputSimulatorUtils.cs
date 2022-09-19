using System;
using System.Collections.Generic;
using System.Text;
using WindowsInput;
using UiTesting.Utils;
using System.Threading;

namespace UiTesting.Utils
{
    public static class InputSimulatorUtils
    {
        private static InputSimulator inputSimulator = new InputSimulator();
        private static AppDomain domain = AppDomain.CurrentDomain;

        public static void UploadImage(string pathToImage)
        {
            Thread.Sleep(500);
            inputSimulator.Keyboard.TextEntry($"{domain.BaseDirectory}{pathToImage}");
            inputSimulator.Keyboard.KeyPress(WindowsInput.Native.VirtualKeyCode.RETURN);
        }
    }
}
