namespace Semulation_Task_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_customers_times = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customersChar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loadDiagram_Btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customers_times)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersChar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_customers_times);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers Informations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DGV_customers_times
            // 
            this.DGV_customers_times.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_customers_times.Location = new System.Drawing.Point(6, 22);
            this.DGV_customers_times.Name = "DGV_customers_times";
            this.DGV_customers_times.Size = new System.Drawing.Size(531, 418);
            this.DGV_customers_times.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadDiagram_Btn);
            this.groupBox2.Controls.Add(this.customersChar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(561, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 440);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagram For Customers";
            // 
            // customersChar
            // 
            chartArea1.Name = "ChartArea1";
            this.customersChar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.customersChar.Legends.Add(legend1);
            this.customersChar.Location = new System.Drawing.Point(6, 22);
            this.customersChar.Name = "customersChar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Arrival Time";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "End Time";
            this.customersChar.Series.Add(series1);
            this.customersChar.Series.Add(series2);
            this.customersChar.Size = new System.Drawing.Size(405, 373);
            this.customersChar.TabIndex = 0;
            this.customersChar.Text = "chart1";
            // 
            // loadDiagram_Btn
            // 
            this.loadDiagram_Btn.Location = new System.Drawing.Point(128, 401);
            this.loadDiagram_Btn.Name = "loadDiagram_Btn";
            this.loadDiagram_Btn.Size = new System.Drawing.Size(126, 33);
            this.loadDiagram_Btn.TabIndex = 1;
            this.loadDiagram_Btn.Text = "Load Diagram";
            this.loadDiagram_Btn.UseVisualStyleBackColor = true;
            this.loadDiagram_Btn.Click += new System.EventHandler(this.loadDiagram_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customers_times)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersChar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV_customers_times;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button loadDiagram_Btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart customersChar;
    }
}

