namespace Cursov_Proekt4
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
            this.components = new System.ComponentModel.Container();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proekt4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proekt4DataSet = new Cursov_Proekt4.proekt4DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dishesTableAdapter = new Cursov_Proekt4.proekt4DataSetTableAdapters.DishesTableAdapter();
            this.___MigrationHistoryTableAdapter1 = new Cursov_Proekt4.proekt4DataSetTableAdapters.@__MigrationHistoryTableAdapter();
            this.deliveryDataSet = new Cursov_Proekt4.DeliveryDataSet();
            this.dishesTableAdapter1 = new Cursov_Proekt4.DeliveryDataSetTableAdapters.DishesTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proekt4DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proekt4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.proekt4DataSetBindingSource;
            // 
            // proekt4DataSetBindingSource
            // 
            this.proekt4DataSetBindingSource.DataSource = this.proekt4DataSet;
            this.proekt4DataSetBindingSource.Position = 0;
            // 
            // proekt4DataSet
            // 
            this.proekt4DataSet.DataSetName = "proekt4DataSet";
            this.proekt4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DishId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DishName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(111, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(65, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(65, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(111, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 164);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Weight";
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // ___MigrationHistoryTableAdapter1
            // 
            this.___MigrationHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // deliveryDataSet
            // 
            this.deliveryDataSet.DataSetName = "DeliveryDataSet";
            this.deliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesTableAdapter1
            // 
            this.dishesTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(65, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(111, 20);
            this.textBox6.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "DishTypeId";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 20;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(469, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 32);
            this.button4.TabIndex = 22;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(201, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(601, 160);
            this.listBox1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 245);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proekt4DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proekt4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private proekt4DataSet proekt4DataSet;
        private System.Windows.Forms.BindingSource proekt4DataSetBindingSource;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private proekt4DataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private proekt4DataSetTableAdapters.__MigrationHistoryTableAdapter ___MigrationHistoryTableAdapter1;
        private DeliveryDataSet deliveryDataSet;
        private DeliveryDataSetTableAdapters.DishesTableAdapter dishesTableAdapter1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}

