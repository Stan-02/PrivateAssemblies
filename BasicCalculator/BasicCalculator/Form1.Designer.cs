namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            label1 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            cmbOperator = new ComboBox();
            btnCompute = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(4, 21);
            label1.Name = "label1";
            label1.Size = new Size(234, 40);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum1.Location = new Point(16, 85);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(352, 48);
            txtNum1.TabIndex = 1;
            txtNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNum2.Location = new Point(16, 200);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(352, 48);
            txtNum2.TabIndex = 2;
            txtNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbOperator
            // 
            cmbOperator.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Location = new Point(137, 149);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new Size(121, 40);
            cmbOperator.TabIndex = 3;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(128, 255, 128);
            btnCompute.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCompute.ForeColor = Color.FromArgb(0, 64, 0);
            btnCompute.Location = new Point(132, 392);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(139, 46);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Black;
            listView1.Font = new Font("Sans Serif Collection", 18F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.ForeColor = Color.Lime;
            listView1.Location = new Point(16, 268);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(352, 106);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(386, 462);
            Controls.Add(listView1);
            Controls.Add(btnCompute);
            Controls.Add(cmbOperator);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "FrmBasicCalculator";
            Text = "Form1";
            Load += FrmBasicCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private ComboBox cmbOperator;
        private Button btnCompute;
        private ListView listView1;
    }
}