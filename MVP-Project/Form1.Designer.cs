namespace MVP_Project
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
            btnCalculate = new Button();
            txtInput = new TextBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.Info;
            btnCalculate.Location = new Point(59, 130);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(181, 32);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "RESULT";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(59, 51);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(181, 26);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.KeyPress += txtInput_KeyPress;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(89, 91);
            lblError.Name = "lblError";
            lblError.Size = new Size(128, 19);
            lblError.TabIndex = 2;
            lblError.Text = "enter an expression";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(306, 450);
            Controls.Add(lblError);
            Controls.Add(txtInput);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtInput;
        private Label lblError;
    }
}