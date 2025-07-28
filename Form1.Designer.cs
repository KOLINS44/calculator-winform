
namespace FinalWinFormsCalcApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[16];
        private string[] labels = new string[]
        {
            "7", "8", "9", "/",
            "4", "5", "6", "*",
            "1", "2", "3", "-",
            "0", "CE", "=", "+"
        };

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Size = new System.Drawing.Size(260, 39);
            this.textBox1.Text = "0";
            this.Controls.Add(this.textBox1);

            int x = 12, y = 60;
            for (int i = 0; i < 16; i++)
            {
                var btn = new System.Windows.Forms.Button();
                btn.Text = labels[i];
                btn.Size = new System.Drawing.Size(60, 40);
                btn.Location = new System.Drawing.Point(x, y);
                btn.Font = new System.Drawing.Font("Segoe UI", 14F);
                if (labels[i] == "=")
                    btn.Click += new System.EventHandler(this.buttonEqual_Click);
                else if (labels[i] == "CE")
                    btn.Click += new System.EventHandler(this.buttonCE_Click);
                else if ("/+*-".Contains(labels[i]))
                    btn.Click += new System.EventHandler(this.Operator_Click);
                else
                    btn.Click += new System.EventHandler(this.Button_Click);
                this.Controls.Add(btn);
                x += 66;
                if ((i + 1) % 4 == 0) { x = 12; y += 46; }
            }

            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
