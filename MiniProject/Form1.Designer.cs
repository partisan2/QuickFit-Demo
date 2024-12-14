namespace MiniProject
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
            label2 = new Label();
            textBlockSizes = new TextBox();
            btnSetBlocks = new Button();
            grpBox1 = new GroupBox();
            txtPrc4 = new TextBox();
            label6 = new Label();
            txtPrc3 = new TextBox();
            label4 = new Label();
            txtPrc2 = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            txtPrc1 = new TextBox();
            label3 = new Label();
            dataGridAllocations = new DataGridView();
            label5 = new Label();
            btnFree = new Button();
            btnFree2 = new Button();
            btnFree3 = new Button();
            btnFree4 = new Button();
            button1 = new Button();
            listBoxFreeLists = new ListBox();
            grpBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllocations).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 110);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 1;
            label2.Text = "Set Block Sizes";
            // 
            // textBlockSizes
            // 
            textBlockSizes.Location = new Point(206, 106);
            textBlockSizes.Name = "textBlockSizes";
            textBlockSizes.Size = new Size(275, 27);
            textBlockSizes.TabIndex = 2;
            // 
            // btnSetBlocks
            // 
            btnSetBlocks.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSetBlocks.Location = new Point(387, 165);
            btnSetBlocks.Name = "btnSetBlocks";
            btnSetBlocks.Size = new Size(94, 29);
            btnSetBlocks.TabIndex = 3;
            btnSetBlocks.Text = "Set";
            btnSetBlocks.UseVisualStyleBackColor = true;
            btnSetBlocks.Click += btnSetBlocks_Click;
            // 
            // grpBox1
            // 
            grpBox1.Controls.Add(txtPrc4);
            grpBox1.Controls.Add(label6);
            grpBox1.Controls.Add(txtPrc3);
            grpBox1.Controls.Add(label4);
            grpBox1.Controls.Add(txtPrc2);
            grpBox1.Controls.Add(label1);
            grpBox1.Controls.Add(btnAdd);
            grpBox1.Controls.Add(txtPrc1);
            grpBox1.Controls.Add(label3);
            grpBox1.Location = new Point(76, 200);
            grpBox1.Name = "grpBox1";
            grpBox1.Size = new Size(444, 274);
            grpBox1.TabIndex = 4;
            grpBox1.TabStop = false;
            grpBox1.Text = "Allocate Memory Blocks";
            // 
            // txtPrc4
            // 
            txtPrc4.Location = new Point(194, 176);
            txtPrc4.Name = "txtPrc4";
            txtPrc4.Size = new Size(211, 27);
            txtPrc4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 179);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 11;
            label6.Text = "Process4 Memory Size ";
            // 
            // txtPrc3
            // 
            txtPrc3.Location = new Point(194, 132);
            txtPrc3.Name = "txtPrc3";
            txtPrc3.Size = new Size(211, 27);
            txtPrc3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 135);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 9;
            label4.Text = "Process3 Memory Size ";
            // 
            // txtPrc2
            // 
            txtPrc2.Location = new Point(194, 86);
            txtPrc2.Name = "txtPrc2";
            txtPrc2.Size = new Size(211, 27);
            txtPrc2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 89);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 7;
            label1.Text = "Process2 Memory Size ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(311, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPrc1
            // 
            txtPrc1.Location = new Point(194, 41);
            txtPrc1.Name = "txtPrc1";
            txtPrc1.Size = new Size(211, 27);
            txtPrc1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 44);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 0;
            label3.Text = "Process1 Memory Size ";
            // 
            // dataGridAllocations
            // 
            dataGridAllocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAllocations.Location = new Point(560, 212);
            dataGridAllocations.Name = "dataGridAllocations";
            dataGridAllocations.RowHeadersWidth = 51;
            dataGridAllocations.Size = new Size(551, 219);
            dataGridAllocations.TabIndex = 6;
            dataGridAllocations.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 29);
            label5.Name = "label5";
            label5.Size = new Size(292, 31);
            label5.TabIndex = 5;
            label5.Text = "Quickfit Algorithm Demo";
            // 
            // btnFree
            // 
            btnFree.Location = new Point(560, 449);
            btnFree.Name = "btnFree";
            btnFree.Size = new Size(115, 29);
            btnFree.TabIndex = 7;
            btnFree.Text = "Free Process1";
            btnFree.UseVisualStyleBackColor = true;
            btnFree.Visible = false;
            btnFree.Click += btnFree_Click;
            // 
            // btnFree2
            // 
            btnFree2.Location = new Point(714, 449);
            btnFree2.Name = "btnFree2";
            btnFree2.Size = new Size(115, 29);
            btnFree2.TabIndex = 8;
            btnFree2.Text = "Free Process2";
            btnFree2.UseVisualStyleBackColor = true;
            btnFree2.Visible = false;
            btnFree2.Click += btnFree2_Click;
            // 
            // btnFree3
            // 
            btnFree3.Location = new Point(853, 449);
            btnFree3.Name = "btnFree3";
            btnFree3.Size = new Size(115, 29);
            btnFree3.TabIndex = 9;
            btnFree3.Text = "Free Process3";
            btnFree3.UseVisualStyleBackColor = true;
            btnFree3.Visible = false;
            btnFree3.Click += btnFree3_Click;
            // 
            // btnFree4
            // 
            btnFree4.Location = new Point(996, 449);
            btnFree4.Name = "btnFree4";
            btnFree4.Size = new Size(115, 29);
            btnFree4.TabIndex = 10;
            btnFree4.Text = "Free Process4";
            btnFree4.UseVisualStyleBackColor = true;
            btnFree4.Visible = false;
            btnFree4.Click += btnFree4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(963, 497);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 11;
            button1.Text = "View Free Address";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // listBoxFreeLists
            // 
            listBoxFreeLists.FormattingEnabled = true;
            listBoxFreeLists.Location = new Point(76, 541);
            listBoxFreeLists.Name = "listBoxFreeLists";
            listBoxFreeLists.Size = new Size(542, 104);
            listBoxFreeLists.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 832);
            Controls.Add(listBoxFreeLists);
            Controls.Add(button1);
            Controls.Add(btnFree4);
            Controls.Add(btnFree3);
            Controls.Add(btnFree2);
            Controls.Add(btnFree);
            Controls.Add(dataGridAllocations);
            Controls.Add(label5);
            Controls.Add(grpBox1);
            Controls.Add(btnSetBlocks);
            Controls.Add(textBlockSizes);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpBox1.ResumeLayout(false);
            grpBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAllocations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBlockSizes;
        private Button btnSetBlocks;
        private GroupBox grpBox1;
        private Label label3;
        private Button btnAdd;
        private TextBox txtPrc1;
        private Label label5;
        private TextBox txtPrc4;
        private Label label6;
        private TextBox txtPrc3;
        private Label label4;
        private TextBox txtPrc2;
        private Label label1;
        private DataGridView dataGridAllocations;
        private Button btnFree;
        private Button btnFree2;
        private Button btnFree3;
        private Button btnFree4;
        private Button button1;
        private ListBox listBoxFreeLists;
    }
}
