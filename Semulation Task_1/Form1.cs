using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semulation_Task_1
{

    public partial class Form1 : Form
    {
        int[] arrivalTime = new int[8];
        int[] endTime = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable customers_times = new DataTable();
            Random random_time = new Random();

            customers_times.Columns.Add("Customer Number", typeof(int));
            customers_times.Columns.Add("Arrival Time", typeof(int));
            customers_times.Columns.Add("Time Service Begins", typeof(int));
            customers_times.Columns.Add("Service Time Duration", typeof(int));
            customers_times.Columns.Add("Time Service Ends", typeof(int));

            //customer1
            int SeviceTimeDuration =  random_time.Next(1, 3);
            customers_times.Rows.Add(1, 0, 0, SeviceTimeDuration, SeviceTimeDuration);
            arrivalTime[0] = 0;
            endTime[0] = SeviceTimeDuration;

            //Customer2
            int arrivalTime2 = random_time.Next(3, 7);
            int timeServiceBegains2 = random_time.Next(3,7);
            int serviceTimeDuration2 = random_time.Next(1, 5);
            int timeServiceEnd2 = timeServiceBegains2 + serviceTimeDuration2;
            customers_times.Rows.Add(2, arrivalTime2, timeServiceBegains2, serviceTimeDuration2, timeServiceEnd2);
            arrivalTime[1] = arrivalTime2;
            endTime[1] = timeServiceEnd2;


            //customer3
            int arrivalTime3 = random_time.Next(8, 12);
            int timeServiceBegains3 = random_time.Next(4, 8);
            int serviceTimeDuration3 = random_time.Next(1, 5);
            int timeServiceEnd3 = timeServiceBegains3 + serviceTimeDuration3;
            customers_times.Rows.Add(3, arrivalTime3, timeServiceBegains3, serviceTimeDuration3, timeServiceEnd3);
            arrivalTime[2] = arrivalTime3;
            endTime[2] = timeServiceEnd3;

            //customer4
            int arrivalTime4 = random_time.Next(12, 16);
            int timeServiceBegains4 = random_time.Next(8,12);
            int serviceTimeDuration4 = random_time.Next(1, 5);
            int timeServiceEnd4 = timeServiceBegains4 + serviceTimeDuration4;
            customers_times.Rows.Add(4, arrivalTime4, timeServiceBegains4, serviceTimeDuration4, timeServiceEnd4);
            arrivalTime[3] = arrivalTime4;
            endTime[3] = timeServiceEnd4;

            //customer5
            int arrivalTime5 = random_time.Next(16, 20);
            int timeServiceBegains5 = random_time.Next(12, 16);
            int serviceTimeDuration5 = random_time.Next(1, 5);
            int timeServiceEnd5 = timeServiceBegains5 + serviceTimeDuration5;
            customers_times.Rows.Add(5, arrivalTime5, timeServiceBegains5, serviceTimeDuration5, timeServiceEnd5);
            arrivalTime[4] = arrivalTime5;
            endTime[4] = timeServiceEnd5;

            //customer6
            int arrivalTime6 = random_time.Next(20, 24);
            int timeServiceBegains6 = random_time.Next(16, 20);
            int serviceTimeDuration6 = random_time.Next(1, 5);
            int timeServiceEnd6 = timeServiceBegains6 + serviceTimeDuration6;
            customers_times.Rows.Add(6, arrivalTime6, timeServiceBegains6, serviceTimeDuration6, timeServiceEnd6);
            arrivalTime[5] = arrivalTime6;
            endTime[5] = timeServiceEnd6;

            //customer7
            int arrivalTime7 = random_time.Next(24, 28);
            int timeServiceBegains7 = random_time.Next(20, 24);
            int serviceTimeDuration7 = random_time.Next(1, 5);
            int timeServiceEnd7 = timeServiceBegains7 + serviceTimeDuration7;
            customers_times.Rows.Add(7, arrivalTime7, timeServiceBegains7, serviceTimeDuration7, timeServiceEnd7);
            arrivalTime[6] = arrivalTime7;
            endTime[6] = timeServiceEnd7;

            //customer8
            int arrivalTime8 = random_time.Next(28, 32);
            int timeServiceBegains8 = random_time.Next(24, 28);
            int serviceTimeDuration8 = random_time.Next(1, 5);
            int timeServiceEnd8 = timeServiceBegains8 + serviceTimeDuration8;
            customers_times.Rows.Add(8, arrivalTime8, timeServiceBegains8, serviceTimeDuration8, timeServiceEnd8);
            arrivalTime[7] = arrivalTime8;
            endTime[7] = timeServiceEnd8;

            DGV_customers_times.DataSource = customers_times;
        }

        private void loadDiagram_Btn_Click(object sender, EventArgs e)
        {
            this.customersChar.Series["Arrival Time"].Points.AddXY(1, arrivalTime[0]);
            this.customersChar.Series["End Time"].Points.AddXY(1, endTime[0]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(2, arrivalTime[1]);
            this.customersChar.Series["End Time"].Points.AddXY(2, endTime[1]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(3, arrivalTime[2]);
            this.customersChar.Series["End Time"].Points.AddXY(3, endTime[2]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(4, arrivalTime[3]);
            this.customersChar.Series["End Time"].Points.AddXY(4, endTime[3]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(5, arrivalTime[4]);
            this.customersChar.Series["End Time"].Points.AddXY(5, endTime[4]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(6, arrivalTime[5]);
            this.customersChar.Series["End Time"].Points.AddXY(6, endTime[5]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(7, arrivalTime[6]);
            this.customersChar.Series["End Time"].Points.AddXY(7, endTime[6]);

            this.customersChar.Series["Arrival Time"].Points.AddXY(8, arrivalTime[7]);
            this.customersChar.Series["End Time"].Points.AddXY(8, endTime[7]);



        }
    }
}
