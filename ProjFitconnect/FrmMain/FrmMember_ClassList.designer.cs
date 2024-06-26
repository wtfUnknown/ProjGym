﻿namespace ProjGym
{
    partial class FrmMember_ClassList
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
            this.flowLayoutPanel_ClassCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_ClassCategories = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Aerobic = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Course = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_ClassCategory
            // 
            this.flowLayoutPanel_ClassCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_ClassCategory.Location = new System.Drawing.Point(156, 112);
            this.flowLayoutPanel_ClassCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_ClassCategory.Name = "flowLayoutPanel_ClassCategory";
            this.flowLayoutPanel_ClassCategory.Size = new System.Drawing.Size(1008, 44);
            this.flowLayoutPanel_ClassCategory.TabIndex = 0;
            // 
            // lbl_ClassCategories
            // 
            this.lbl_ClassCategories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_ClassCategories.AutoSize = true;
            this.lbl_ClassCategories.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_ClassCategories.Location = new System.Drawing.Point(27, 121);
            this.lbl_ClassCategories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ClassCategories.Name = "lbl_ClassCategories";
            this.lbl_ClassCategories.Size = new System.Drawing.Size(116, 31);
            this.lbl_ClassCategories.TabIndex = 1;
            this.lbl_ClassCategories.Text = "課程類型:";
            // 
            // flowLayoutPanel_Aerobic
            // 
            this.flowLayoutPanel_Aerobic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Aerobic.Location = new System.Drawing.Point(156, 61);
            this.flowLayoutPanel_Aerobic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_Aerobic.Name = "flowLayoutPanel_Aerobic";
            this.flowLayoutPanel_Aerobic.Size = new System.Drawing.Size(300, 44);
            this.flowLayoutPanel_Aerobic.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "有氧/無氧:";
            // 
            // dataGridView_Test
            // 
            this.dataGridView_Test.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Test.Location = new System.Drawing.Point(21, 616);
            this.dataGridView_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersWidth = 51;
            this.dataGridView_Test.RowTemplate.Height = 24;
            this.dataGridView_Test.Size = new System.Drawing.Size(1143, 279);
            this.dataGridView_Test.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Search.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Search.Location = new System.Drawing.Point(520, 66);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 32);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查詢";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // flowLayoutPanel_Course
            // 
            this.flowLayoutPanel_Course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_Course.AutoScroll = true;
            this.flowLayoutPanel_Course.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Course.Location = new System.Drawing.Point(21, 180);
            this.flowLayoutPanel_Course.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel_Course.Name = "flowLayoutPanel_Course";
            this.flowLayoutPanel_Course.Size = new System.Drawing.Size(1142, 428);
            this.flowLayoutPanel_Course.TabIndex = 4;
            // 
            // FrmMember_ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1212, 910);
            this.Controls.Add(this.flowLayoutPanel_Course);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dataGridView_Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel_Aerobic);
            this.Controls.Add(this.lbl_ClassCategories);
            this.Controls.Add(this.flowLayoutPanel_ClassCategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMember_ClassList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member | 課程查詢";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ClassCategory;
        private System.Windows.Forms.Label lbl_ClassCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Aerobic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Test;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Course;
    }
}