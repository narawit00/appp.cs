namespace appp.cs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnCircleArea = new Button();
            txtRadius = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            btnTriangleArea = new Button();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            txtHexagonWidth = new TextBox();
            btnHexagonArea = new Button();
            button4 = new Button();
            lblResult = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleTurquoise;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวนพื้นที่วงกลม";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 65);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "รัศมี";
            // 
            // btnCircleArea
            // 
            btnCircleArea.BackColor = Color.Teal;
            btnCircleArea.Location = new Point(350, 67);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(170, 29);
            btnCircleArea.TabIndex = 1;
            btnCircleArea.Text = "คำนวนพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = false;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // txtRadius
            // 
            txtRadius.BackColor = Color.PaleTurquoise;
            txtRadius.Location = new Point(134, 68);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(178, 27);
            txtRadius.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightSeaGreen;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(12, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(544, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวนพื้นที่สามเหลี่ยม";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "ตามมาตรฐาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "ความสุง";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.BackColor = Color.Teal;
            btnTriangleArea.Location = new Point(350, 56);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(170, 29);
            btnTriangleArea.TabIndex = 2;
            btnTriangleArea.Text = "คำนวนพื้นที่สามเหลียม";
            btnTriangleArea.UseVisualStyleBackColor = false;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // txtWidth
            // 
            txtWidth.BackColor = Color.PaleTurquoise;
            txtWidth.Location = new Point(134, 83);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(178, 27);
            txtWidth.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.BackColor = Color.PaleTurquoise;
            txtHeight.Location = new Point(134, 33);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(178, 27);
            txtHeight.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Teal;
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.ForeColor = Color.Navy;
            groupBox3.Location = new Point(12, 371);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(544, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวนพื้นที่หกเหลียม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 57);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 5;
            label4.Text = "ความกว้างมาตรฐาน";
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.BackColor = Color.PaleTurquoise;
            txtHexagonWidth.Location = new Point(134, 57);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(178, 27);
            txtHexagonWidth.TabIndex = 3;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.BackColor = Color.DarkCyan;
            btnHexagonArea.Location = new Point(350, 57);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(170, 29);
            btnHexagonArea.TabIndex = 2;
            btnHexagonArea.Text = "คำนวนพื้นที่หกเหลียม";
            btnHexagonArea.UseVisualStyleBackColor = false;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(266, 535);
            button4.Name = "button4";
            button4.Size = new Size(416, 47);
            button4.TabIndex = 3;
            button4.Text = "IF YOU WANT TO CLOSE PLESE CLICK HERE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.PowderBlue;
            lblResult.ForeColor = SystemColors.HotTrack;
            lblResult.Location = new Point(629, 207);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(270, 289);
            lblResult.TabIndex = 4;
            lblResult.Text = "These number is show here..";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSeaGreen;
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(629, 176);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "พื้นที่ตารางคำนวน";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(923, 594);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCircleArea;
        private TextBox txtRadius;
        private GroupBox groupBox2;
        private Button btnTriangleArea;
        private TextBox txtHeight;
        private GroupBox groupBox3;
        private Button btnHexagonArea;
        private TextBox txtWidth;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txtHexagonWidth;
        private Label label4;
        private Button button4;
        private Label lblResult;
        private Label label6;
    }
}
