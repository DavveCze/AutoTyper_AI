namespace AutoTyper
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Delay = new System.Windows.Forms.NumericUpDown();
            this.btn_Advanced = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Text
            // 
            resources.ApplyResources(this.txt_Text, "txt_Text");
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.TextChanged += new System.EventHandler(this.txt_Text_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Delay);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Delay
            // 
            this.Delay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            resources.ApplyResources(this.Delay, "Delay");
            this.Delay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Delay.Name = "Delay";
            this.Delay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // btn_Advanced
            // 
            resources.ApplyResources(this.btn_Advanced, "btn_Advanced");
            this.btn_Advanced.Name = "btn_Advanced";
            this.btn_Advanced.UseVisualStyleBackColor = true;
            this.btn_Advanced.Click += new System.EventHandler(this.btn_Advanced_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 16;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 16;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Advanced);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Text);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Delay;
        private System.Windows.Forms.Button btn_Advanced;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer3;
    }
}

