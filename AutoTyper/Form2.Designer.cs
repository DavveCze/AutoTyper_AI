namespace AutoTyper
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Max_C = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Min_C = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Max_W = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Min_W = new System.Windows.Forms.NumericUpDown();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.btn_Simple = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_W)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Max_C);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Min_C);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Max_W);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Min_W);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Max_C
            // 
            this.Max_C.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            resources.ApplyResources(this.Max_C, "Max_C");
            this.Max_C.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Max_C.Name = "Max_C";
            this.Max_C.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Min_C
            // 
            this.Min_C.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            resources.ApplyResources(this.Min_C, "Min_C");
            this.Min_C.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Min_C.Name = "Min_C";
            this.Min_C.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Max_W
            // 
            this.Max_W.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            resources.ApplyResources(this.Max_W, "Max_W");
            this.Max_W.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Max_W.Name = "Max_W";
            this.Max_W.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Min_W
            // 
            this.Min_W.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            resources.ApplyResources(this.Min_W, "Min_W");
            this.Min_W.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Min_W.Name = "Min_W";
            this.Min_W.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // txt_Text
            // 
            resources.ApplyResources(this.txt_Text, "txt_Text");
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.TextChanged += new System.EventHandler(this.txt_Text_TextChanged);
            // 
            // btn_Simple
            // 
            resources.ApplyResources(this.btn_Simple, "btn_Simple");
            this.btn_Simple.Name = "btn_Simple";
            this.btn_Simple.UseVisualStyleBackColor = true;
            this.btn_Simple.Click += new System.EventHandler(this.btn_Simple_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 16;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 16;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Simple);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Text);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Max_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Max_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_W)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Max_C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Min_C;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Max_W;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Min_W;
        private System.Windows.Forms.Button btn_Simple;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}