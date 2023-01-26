namespace SysChroma
{
    using ColoreColor = Corale.Colore.Core.Color;
    using Corale.Colore.Razer.Keyboard;
    using Corale.Colore.Core;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;
        private PerformanceCounter tempCounter;

        int mbTotal = (int)(31.8 * 1024);

        ColoreColor defaultColor = new ColoreColor((byte)32, (byte)32, (byte)32);
        ColoreColor cpuBlue = new ColoreColor((byte)32, (byte)96, (byte)255);
        ColoreColor ramPurple = new ColoreColor((byte)196, (byte)32, (byte)255);
        ColoreColor gpuGreen = new ColoreColor((byte)32, (byte)255, (byte)0);
        ColoreColor okayBlue = new ColoreColor((byte)0, (byte)196, (byte)196);
        ColoreColor warningAmber = new ColoreColor((byte)255, (byte)128, (byte)0);
        ColoreColor dangerRed = new ColoreColor((byte)255, (byte)16, (byte)0);

        public Form1()
        {
            InitializeComponent();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total", true);
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);
            tempCounter = new PerformanceCounter("Thermal Zone Information", "Temperature", "\\_TZ.THRM", true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Chroma.Instance.SetAll(defaultColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double cpu = (double)cpuCounter.NextValue();
            double ram = (1 - ((double)ramCounter.NextValue() / mbTotal)) * 100;
            double gpu = getGPUUse();
            double cpuThermals = (double)tempCounter.NextValue() - 273.15;
            labelCPU.Text = "CPU: " + Math.Round(cpu, 1) + "%";
            labelRAM.Text = "RAM: " + Math.Round(((ram * mbTotal) / 102400), 1) + " GiB";
            labelGPU.Text = "GPU: " + Math.Round(gpu, 1) + "%";
            labelThermals.Text = "TEMP: " + Math.Round(cpuThermals, 1) + "°C";

            if (checkBoxCPU.Checked)
            {
                if (cpu >= 80)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F1, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F2, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F3, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F4, cpuBlue);
                }
                else if (cpu >= 60)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F1, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F2, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F3, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F4, defaultColor);
                }
                else if (cpu >= 40)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F1, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F2, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F3, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F4, defaultColor);
                }
                else if (cpu >= 20)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F1, cpuBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.F2, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F3, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F4, defaultColor);
                }
                else
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F1, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F2, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F3, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F4, defaultColor);
                }
            }
            else
            {
                Chroma.Instance.Keyboard.SetKey(Key.F1, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F2, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F3, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F4, defaultColor);
            }

            if (checkBoxRAM.Checked)
            {
                if (ram >= 80)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F5, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F6, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F7, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F8, ramPurple);
                }
                else if (ram >= 60)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F5, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F6, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F7, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F8, defaultColor);
                }
                else if (ram >= 40)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F5, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F6, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F7, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F8, defaultColor);
                }
                else if (ram >= 20)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F5, ramPurple);
                    Chroma.Instance.Keyboard.SetKey(Key.F6, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F7, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F8, defaultColor);
                }
                else
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F5, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F6, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F7, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F8, defaultColor);
                }
            }
            else
            {
                Chroma.Instance.Keyboard.SetKey(Key.F5, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F6, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F7, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F8, defaultColor);
            }

            if (checkBoxGPU.Checked)
            {
                if (gpu >= 80)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F9, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F10, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F11, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F12, gpuGreen);
                }
                else if (gpu >= 60)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F9, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F10, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F11, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F12, defaultColor);
                }
                else if (gpu >= 40)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F9, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F10, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F11, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F12, defaultColor);
                }
                else if (gpu >= 20)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F9, gpuGreen);
                    Chroma.Instance.Keyboard.SetKey(Key.F10, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F11, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F12, defaultColor);
                }
                else
                {
                    Chroma.Instance.Keyboard.SetKey(Key.F9, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F10, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F11, defaultColor);
                    Chroma.Instance.Keyboard.SetKey(Key.F12, defaultColor);
                }
            }
            else
            {
                Chroma.Instance.Keyboard.SetKey(Key.F9, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F10, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F11, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.F12, defaultColor);
            }

            if (checkBoxThermals.Checked)
            {
                if (cpuThermals >= 95)
                {
                    Chroma.Instance.Keyboard.SetKey(Key.PrintScreen, dangerRed);
                    Chroma.Instance.Keyboard.SetKey(Key.Scroll, dangerRed);
                    Chroma.Instance.Keyboard.SetKey(Key.Pause, dangerRed);
                }
                else if (cpuThermals >= 85) {
                    Chroma.Instance.Keyboard.SetKey(Key.PrintScreen, warningAmber);
                    Chroma.Instance.Keyboard.SetKey(Key.Scroll, warningAmber);
                    Chroma.Instance.Keyboard.SetKey(Key.Pause, warningAmber);
                }
                else
                {
                    Chroma.Instance.Keyboard.SetKey(Key.PrintScreen, okayBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.Scroll, okayBlue);
                    Chroma.Instance.Keyboard.SetKey(Key.Pause, okayBlue);
                }
            }
            else
            {
                Chroma.Instance.Keyboard.SetKey(Key.PrintScreen, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.Scroll, defaultColor);
                Chroma.Instance.Keyboard.SetKey(Key.Pause, defaultColor);
            }
        }
        

        public double getGPUUse()
        {
            try
            {
                var category = new PerformanceCounterCategory("GPU Engine");
                var counterNames = category.GetInstanceNames();

                var gpuCounters = counterNames.Where(counterName => counterName.EndsWith("engtype_3D")).SelectMany(counterName => category.GetCounters(counterName)).Where(counter => counter.CounterName.Equals("Utilization Percentage")).ToList();

                gpuCounters.ForEach(x => x.NextValue());

                Thread.Sleep(10);

                var result = gpuCounters.Sum(x => x.NextValue());

                return result;
            }
            catch
            {
                return 0.0;
            }
        }
    }
}