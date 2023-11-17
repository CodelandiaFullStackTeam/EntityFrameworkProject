namespace EntityFrameworkProject
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
            txtName = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(432, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(366, 27);
            txtName.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(252, 74);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(801, 313);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 30);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(303, 76);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(252, 74);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(576, 76);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(252, 74);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 7;
            label2.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 27);
            txtId.Name = "txtId";
            txtId.Size = new Size(137, 27);
            txtId.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 612);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label2;
        private TextBox txtId;
    }
}