namespace FlightSimulatorControlCenter
{
    partial class AcquistoBiglietto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Volo?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 38);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "n Posti Disponibili";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(441, 38);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Compra";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(67, 174);
            button1.Name = "button1";
            button1.Size = new Size(177, 76);
            button1.TabIndex = 3;
            button1.Text = "Acquista";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(342, 174);
            button2.Name = "button2";
            button2.Size = new Size(177, 76);
            button2.TabIndex = 4;
            button2.Text = "Annulla";
            button2.UseVisualStyleBackColor = true;
            // 
            // AcquistoBiglietto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 299);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AcquistoBiglietto";
            Text = "AcquistoBiglietto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}