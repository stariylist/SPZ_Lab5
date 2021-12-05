using SPZ_Lab5.Model;

namespace SPZ_Lab5
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
            Serialization.Serialize(StoragePath, Repository.Students);
            Serialization.Serialize(GroupListPath, Groups.GroupNamesList);
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.output_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.StudentInfo_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Information about students and groups";
            // 
            // output_comboBox
            // 
            this.output_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.output_comboBox.FormattingEnabled = true;
            this.output_comboBox.Location = new System.Drawing.Point(410, 31);
            this.output_comboBox.Name = "output_comboBox";
            this.output_comboBox.Size = new System.Drawing.Size(151, 33);
            this.output_comboBox.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(27, 82);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(485, 443);
            this.dataGridView.TabIndex = 3;
            // 
            // StudentInfo_button
            // 
            this.StudentInfo_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentInfo_button.Location = new System.Drawing.Point(27, 540);
            this.StudentInfo_button.Name = "StudentInfo_button";
            this.StudentInfo_button.Size = new System.Drawing.Size(141, 71);
            this.StudentInfo_button.TabIndex = 4;
            this.StudentInfo_button.Text = "Change student\'s info";
            this.StudentInfo_button.UseVisualStyleBackColor = false;
            this.StudentInfo_button.Click += new System.EventHandler(this.StudentInfo_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(371, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change group\'s info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(569, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentInfo_button);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.output_comboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox output_comboBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button StudentInfo_button;
        private System.Windows.Forms.Button button1;
    }
}

