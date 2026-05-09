namespace TodoList_Project
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
            label1 = new Label();
            txtTitle = new TextBox();
            btnAdd = new Button();
            lstTodos = new ListBox();
            btnLoad = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnToggle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F);
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入代辦事項";
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft JhengHei UI", 12F);
            txtTitle.Location = new Point(43, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(427, 28);
            txtTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft JhengHei UI", 12F);
            btnAdd.Location = new Point(488, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 33);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstTodos
            // 
            lstTodos.FormattingEnabled = true;
            lstTodos.Location = new Point(43, 102);
            lstTodos.Name = "lstTodos";
            lstTodos.Size = new Size(549, 304);
            lstTodos.TabIndex = 3;
            lstTodos.SelectedIndexChanged += lstTodos_SelectedIndexChanged;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Microsoft JhengHei UI", 12F);
            btnLoad.Location = new Point(635, 255);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(106, 37);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "讀取";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft JhengHei UI", 12F);
            btnSave.Location = new Point(635, 204);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "儲存";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 12F);
            btnDelete.Location = new Point(635, 153);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 37);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "刪除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Microsoft JhengHei UI", 12F);
            btnToggle.Location = new Point(635, 102);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(106, 37);
            btnToggle.TabIndex = 7;
            btnToggle.Text = "完成/取消";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToggle);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(lstTodos);
            Controls.Add(btnAdd);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "我的代辦事項";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Button btnAdd;
        private ListBox lstTodos;
        private Button btnLoad;
        private Button btnSave;
        private Button btnDelete;
        private Button btnToggle;
    }
}
