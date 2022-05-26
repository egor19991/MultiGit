
namespace MorLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buildGraphics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSearchPoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEpsX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEpsY = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMantissa = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(658, 433);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buildGraphics
            // 
            this.buildGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buildGraphics.Location = new System.Drawing.Point(679, 401);
            this.buildGraphics.Name = "buildGraphics";
            this.buildGraphics.Size = new System.Drawing.Size(100, 38);
            this.buildGraphics.TabIndex = 1;
            this.buildGraphics.Text = "Построение графика";
            this.buildGraphics.UseVisualStyleBackColor = true;
            this.buildGraphics.Click += new System.EventHandler(this.buildGraphics_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(675, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Минимальная граница графика a";
            // 
            // textBoxA
            // 
            this.textBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxA.Location = new System.Drawing.Point(679, 36);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 3;
            this.textBoxA.Leave += new System.EventHandler(this.textBoxA_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(675, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Максимальная граница графика b";
            // 
            // textBoxB
            // 
            this.textBoxB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxB.Location = new System.Drawing.Point(681, 92);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 20);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.Leave += new System.EventHandler(this.textBoxB_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Шаг поиска h";
            // 
            // textBoxH
            // 
            this.textBoxH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxH.Location = new System.Drawing.Point(677, 170);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 7;
            this.textBoxH.Leave += new System.EventHandler(this.textBoxH_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Интервал графика";
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterval.Location = new System.Drawing.Point(677, 131);
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInterval.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterval.TabIndex = 10;
            this.textBoxInterval.Leave += new System.EventHandler(this.textBoxInterval_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(675, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Начальная точка поиска X0";
            // 
            // textBoxSearchPoint
            // 
            this.textBoxSearchPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPoint.Location = new System.Drawing.Point(678, 225);
            this.textBoxSearchPoint.Name = "textBoxSearchPoint";
            this.textBoxSearchPoint.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPoint.TabIndex = 12;
            this.textBoxSearchPoint.Leave += new System.EventHandler(this.textBoxSearchPoint_Leave);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(675, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 35);
            this.label7.TabIndex = 13;
            this.label7.Text = "Точность вычисления по X";
            // 
            // textBoxEpsX
            // 
            this.textBoxEpsX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpsX.Location = new System.Drawing.Point(677, 277);
            this.textBoxEpsX.Name = "textBoxEpsX";
            this.textBoxEpsX.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpsX.TabIndex = 14;
            this.textBoxEpsX.Leave += new System.EventHandler(this.textBoxEpsX_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(677, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 33);
            this.label8.TabIndex = 15;
            this.label8.Text = "Точность вычисления по Y";
            // 
            // textBoxEpsY
            // 
            this.textBoxEpsY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEpsY.Location = new System.Drawing.Point(677, 327);
            this.textBoxEpsY.Name = "textBoxEpsY";
            this.textBoxEpsY.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpsY.TabIndex = 16;
            this.textBoxEpsY.Leave += new System.EventHandler(this.textBoxEpsY_Leave);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(0, 6);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = true;
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMessage.Size = new System.Drawing.Size(793, 200);
            this.textBoxMessage.TabIndex = 17;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Location = new System.Drawing.Point(678, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "Кол-во цифр после запятой";
            // 
            // textBoxMantissa
            // 
            this.textBoxMantissa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMantissa.Location = new System.Drawing.Point(678, 375);
            this.textBoxMantissa.Name = "textBoxMantissa";
            this.textBoxMantissa.Size = new System.Drawing.Size(97, 20);
            this.textBoxMantissa.TabIndex = 19;
            this.textBoxMantissa.Leave += new System.EventHandler(this.textBoxMantissa_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.chart1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxMantissa);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.buildGraphics);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEpsY);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxA);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEpsX);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxB);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearchPoint);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxH);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxInterval);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMessage);
            this.splitContainer1.Size = new System.Drawing.Size(796, 658);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(820, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buildGraphics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSearchPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEpsX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxEpsY;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMantissa;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

