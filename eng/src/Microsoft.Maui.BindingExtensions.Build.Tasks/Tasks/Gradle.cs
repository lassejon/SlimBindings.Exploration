using Microsoft.Build.Framework;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Microsoft.Maui.BindingExtensions.Build.Tasks
{
    public class Gradle : BindingToolTask
    {
        public override string TaskPrefix => "GDL";

        protected override string ToolName => RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "gradlew.bat" : "gradlew";


        public string AndroidSdkDirectory { get; set; } = string.Empty;

        public string JavaSdkDirectory { get; set; } = string.Empty;
        public string MyProperty { get; set; }

        public string ToolPath { get; set; } = string.Empty;

        public string Arguments { get; set; } = string.Empty;

        public Gradle()
        {
        }

        protected override string GenerateFullPathToTool()
        {
            return Path.Combine(ToolPath, ToolExe);
        }

        protected override string GenerateCommandLineCommands() => Arguments;

        protected override ProcessStartInfo GetProcessStartInfo(string pathToTool, string commandLineCommands, string responseFileSwitch)
        {
            ProcessStartInfo psi = base.GetProcessStartInfo(pathToTool, commandLineCommands, responseFileSwitch);
            Console.WriteLine($"ProcessStartInfo: {psi}");
            Console.WriteLine($"AndroidSdkDirectory: {AndroidSdkDirectory}");
            Console.WriteLine($"JavaSdkDirectory: {JavaSdkDirectory}");
            Console.WriteLine($"JAVA_HOME: {Environment.GetEnvironmentVariable("JAVA_HOME")}");
            Console.WriteLine($"ANDROID_HOME: {Environment.GetEnvironmentVariable("ANDROID_HOME")}");
            Console.WriteLine($"toolPath: {ToolPath}");

            if (Directory.Exists(AndroidSdkDirectory))
                psi.Environment["ANDROID_HOME"] = AndroidSdkDirectory;

            if (Directory.Exists(JavaSdkDirectory))
                psi.Environment["JAVA_HOME"] = JavaSdkDirectory;

            return psi;
        }

    }
}
