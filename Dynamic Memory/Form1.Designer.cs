namespace Dynamic_Memory
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
            BtnAdd = new Button();
            ListViewDataList = new ListView();
            label1 = new Label();
            TxtAdd = new TextBox();
            LblSize = new Label();
            label2 = new Label();
            BtnDelete = new Button();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(97, 198);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Añadir";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // ListViewDataList
            // 
            ListViewDataList.Location = new Point(419, 12);
            ListViewDataList.Name = "ListViewDataList";
            ListViewDataList.Size = new Size(171, 426);
            ListViewDataList.TabIndex = 1;
            ListViewDataList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 121);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 2;
            label1.Text = "Dato agregado";
            // 
            // TxtAdd
            // 
            TxtAdd.Location = new Point(87, 154);
            TxtAdd.Name = "TxtAdd";
            TxtAdd.Size = new Size(227, 23);
            TxtAdd.TabIndex = 3;
            // 
            // LblSize
            // 
            LblSize.AutoSize = true;
            LblSize.Location = new Point(235, 57);
            LblSize.Name = "LblSize";
            LblSize.Size = new Size(0, 15);
            LblSize.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 57);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Tamaño de la lista";
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(225, 198);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 6;
            BtnDelete.Text = "Borrar";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 450);
            Controls.Add(BtnDelete);
            Controls.Add(label2);
            Controls.Add(LblSize);
            Controls.Add(TxtAdd);
            Controls.Add(label1);
            Controls.Add(ListViewDataList);
            Controls.Add(BtnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private ListView ListViewDataList;
        private Label label1;
        private TextBox TxtAdd;
        private Label LblSize;
        private Label label2;
        private Button BtnDelete;
    }
}
