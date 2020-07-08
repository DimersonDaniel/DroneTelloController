using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;


namespace DroneUI
{
    


    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private int PressA = 0;
        private int PressS = 0;
        private int PressW = 0;
        private int PressD = 0;

        private SDK commandDrone = new SDK();

        private DroneConnection droneConnection = new SDK().InitConnection();

        private int DistanciaMaxima = 500;

        private void Form_Load(object sender, System.EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            commandDrone.SendReceive(droneConnection, $"takeoff");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            commandDrone.SendReceive(droneConnection, $"land");
        }



        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                PressA++;
                AText.Text = "A \r\n" + PressA.ToString();

                commandDrone.SendReceive(droneConnection, $"left {PressA}");

                if (PressA >= DistanciaMaxima)
                {
                    PressA = 0;
                    AText.Text = "A";
                }
            }

            if (e.KeyCode == Keys.S)
            {
                PressS++;
                SText.Text = "S \r\n" + PressS.ToString();

                commandDrone.SendReceive(droneConnection, $"back {PressS}");

                if (PressS >= DistanciaMaxima)
                {
                    PressS = 0;
                    SText.Text = "S";
                }
            }

            if (e.KeyCode == Keys.W)
            {
                PressW++;
                WText.Text = "W \r\n" + PressW.ToString();

                commandDrone.SendReceive(droneConnection, $"forward {PressW}");

                if (PressW >= DistanciaMaxima)
                {
                    PressW = 0;
                    WText.Text = "W";
                }
            }

            if (e.KeyCode == Keys.D)
            {
                PressD++;
                DText.Text = "D \r\n" + PressD.ToString();

                commandDrone.SendReceive(droneConnection, $"right {PressD}");

                if (PressD >= DistanciaMaxima)
                {
                    PressD = 0;
                    DText.Text = "D";
                }
            }
        }
    }
}
