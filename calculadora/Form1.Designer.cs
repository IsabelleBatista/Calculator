namespace calculadora
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
            deleteAll = new Button();
            delete = new Button();
            multipli = new Button();
            division = new Button();
            sum = new Button();
            n9 = new Button();
            n8 = new Button();
            n7 = new Button();
            equal = new Button();
            subtract = new Button();
            n6 = new Button();
            n5 = new Button();
            n4 = new Button();
            visor = new TextBox();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            n0 = new Button();
            dot = new Button();
            SuspendLayout();
            // 
            // deleteAll
            // 
            deleteAll.BackColor = Color.FromArgb(77, 120, 168);
            deleteAll.CausesValidation = false;
            deleteAll.Cursor = Cursors.Hand;
            deleteAll.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            deleteAll.FlatAppearance.BorderSize = 2;
            deleteAll.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            deleteAll.ForeColor = SystemColors.Control;
            deleteAll.Location = new Point(3, 99);
            deleteAll.Name = "deleteAll";
            deleteAll.Size = new Size(65, 57);
            deleteAll.TabIndex = 1;
            deleteAll.Text = "CE";
            deleteAll.UseVisualStyleBackColor = false;
            deleteAll.Click += delete_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(77, 120, 168);
            delete.CausesValidation = false;
            delete.Cursor = Cursors.Hand;
            delete.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            delete.FlatAppearance.BorderSize = 2;
            delete.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            delete.ForeColor = SystemColors.Control;
            delete.Location = new Point(63, 99);
            delete.Name = "delete";
            delete.Size = new Size(65, 57);
            delete.TabIndex = 2;
            delete.Text = "C";
            delete.UseVisualStyleBackColor = false;
            delete.Click += deleteAll_Click;
            // 
            // multipli
            // 
            multipli.BackColor = Color.FromArgb(77, 120, 168);
            multipli.CausesValidation = false;
            multipli.Cursor = Cursors.Hand;
            multipli.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            multipli.FlatAppearance.BorderSize = 2;
            multipli.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            multipli.ForeColor = SystemColors.Control;
            multipli.Location = new Point(183, 99);
            multipli.Name = "multipli";
            multipli.Size = new Size(65, 57);
            multipli.TabIndex = 4;
            multipli.Text = "X";
            multipli.UseVisualStyleBackColor = false;
            multipli.Click += button_Click;
            // 
            // division
            // 
            division.BackColor = Color.FromArgb(77, 120, 168);
            division.CausesValidation = false;
            division.Cursor = Cursors.Hand;
            division.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            division.FlatAppearance.BorderSize = 2;
            division.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            division.ForeColor = SystemColors.Control;
            division.Location = new Point(123, 99);
            division.Name = "division";
            division.Size = new Size(65, 57);
            division.TabIndex = 3;
            division.Text = "÷";
            division.UseVisualStyleBackColor = false;
            division.Click += button_Click;
            // 
            // sum
            // 
            sum.BackColor = Color.FromArgb(77, 120, 168);
            sum.CausesValidation = false;
            sum.Cursor = Cursors.Hand;
            sum.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            sum.FlatAppearance.BorderSize = 2;
            sum.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            sum.ForeColor = SystemColors.Control;
            sum.Location = new Point(183, 153);
            sum.Name = "sum";
            sum.Size = new Size(65, 57);
            sum.TabIndex = 8;
            sum.Text = "+";
            sum.UseVisualStyleBackColor = false;
            sum.Click += button_Click;
            // 
            // n9
            // 
            n9.BackColor = Color.FromArgb(77, 120, 168);
            n9.CausesValidation = false;
            n9.Cursor = Cursors.Hand;
            n9.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n9.FlatAppearance.BorderSize = 2;
            n9.Font = new Font("Tahoma", 14F);
            n9.ForeColor = SystemColors.Control;
            n9.Location = new Point(123, 153);
            n9.Name = "n9";
            n9.Size = new Size(65, 57);
            n9.TabIndex = 7;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = false;
            n9.Click += button_Click;
            // 
            // n8
            // 
            n8.BackColor = Color.FromArgb(77, 120, 168);
            n8.CausesValidation = false;
            n8.Cursor = Cursors.Hand;
            n8.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n8.FlatAppearance.BorderSize = 2;
            n8.Font = new Font("Tahoma", 14F);
            n8.ForeColor = SystemColors.Control;
            n8.Location = new Point(63, 153);
            n8.Name = "n8";
            n8.Size = new Size(65, 57);
            n8.TabIndex = 6;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = false;
            n8.Click += button_Click;
            // 
            // n7
            // 
            n7.BackColor = Color.FromArgb(77, 120, 168);
            n7.CausesValidation = false;
            n7.Cursor = Cursors.Hand;
            n7.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n7.FlatAppearance.BorderSize = 2;
            n7.Font = new Font("Tahoma", 14F);
            n7.ForeColor = SystemColors.Control;
            n7.Location = new Point(3, 153);
            n7.Name = "n7";
            n7.Size = new Size(65, 57);
            n7.TabIndex = 5;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = false;
            n7.Click += button_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.FromArgb(77, 120, 168);
            equal.CausesValidation = false;
            equal.Cursor = Cursors.Hand;
            equal.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            equal.FlatAppearance.BorderSize = 2;
            equal.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            equal.ForeColor = SystemColors.Control;
            equal.Location = new Point(183, 261);
            equal.Name = "equal";
            equal.Size = new Size(65, 111);
            equal.TabIndex = 16;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // subtract
            // 
            subtract.BackColor = Color.FromArgb(77, 120, 168);
            subtract.CausesValidation = false;
            subtract.Cursor = Cursors.Hand;
            subtract.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            subtract.FlatAppearance.BorderSize = 2;
            subtract.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            subtract.ForeColor = SystemColors.Control;
            subtract.Location = new Point(183, 207);
            subtract.Name = "subtract";
            subtract.Size = new Size(65, 57);
            subtract.TabIndex = 12;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            subtract.Click += button_Click;
            // 
            // n6
            // 
            n6.BackColor = Color.FromArgb(77, 120, 168);
            n6.CausesValidation = false;
            n6.Cursor = Cursors.Hand;
            n6.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n6.FlatAppearance.BorderSize = 2;
            n6.Font = new Font("Tahoma", 14F);
            n6.ForeColor = SystemColors.Control;
            n6.Location = new Point(123, 207);
            n6.Name = "n6";
            n6.Size = new Size(65, 57);
            n6.TabIndex = 11;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = false;
            n6.Click += button_Click;
            // 
            // n5
            // 
            n5.BackColor = Color.FromArgb(77, 120, 168);
            n5.CausesValidation = false;
            n5.Cursor = Cursors.Hand;
            n5.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n5.FlatAppearance.BorderSize = 2;
            n5.Font = new Font("Tahoma", 14F);
            n5.ForeColor = SystemColors.Control;
            n5.Location = new Point(63, 207);
            n5.Name = "n5";
            n5.Size = new Size(65, 57);
            n5.TabIndex = 10;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = false;
            n5.Click += button_Click;
            // 
            // n4
            // 
            n4.BackColor = Color.FromArgb(77, 120, 168);
            n4.CausesValidation = false;
            n4.Cursor = Cursors.Hand;
            n4.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n4.FlatAppearance.BorderSize = 2;
            n4.Font = new Font("Tahoma", 14F);
            n4.ForeColor = SystemColors.Control;
            n4.Location = new Point(3, 207);
            n4.Name = "n4";
            n4.Size = new Size(65, 57);
            n4.TabIndex = 9;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = false;
            n4.Click += button_Click;
            // 
            // visor
            // 
            visor.BackColor = Color.FromArgb(71, 97, 94);
            visor.BorderStyle = BorderStyle.None;
            visor.Font = new Font("Tahoma", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visor.ForeColor = SystemColors.Control;
            visor.Location = new Point(7, 55);
            visor.Multiline = true;
            visor.Name = "visor";
            visor.RightToLeft = RightToLeft.Yes;
            visor.Size = new Size(233, 38);
            visor.TabIndex = 17;
            visor.Text = "0";
            visor.TextAlign = HorizontalAlignment.Center;
            // 
            // n1
            // 
            n1.BackColor = Color.FromArgb(77, 120, 168);
            n1.CausesValidation = false;
            n1.Cursor = Cursors.Hand;
            n1.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n1.FlatAppearance.BorderSize = 2;
            n1.Font = new Font("Tahoma", 14F);
            n1.ForeColor = SystemColors.Control;
            n1.Location = new Point(3, 261);
            n1.Name = "n1";
            n1.Size = new Size(65, 57);
            n1.TabIndex = 13;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = false;
            n1.Click += button_Click;
            // 
            // n2
            // 
            n2.BackColor = Color.FromArgb(77, 120, 168);
            n2.CausesValidation = false;
            n2.Cursor = Cursors.Hand;
            n2.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n2.FlatAppearance.BorderSize = 2;
            n2.Font = new Font("Tahoma", 14F);
            n2.ForeColor = SystemColors.Control;
            n2.Location = new Point(63, 261);
            n2.Name = "n2";
            n2.Size = new Size(65, 57);
            n2.TabIndex = 14;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = false;
            n2.Click += button_Click;
            // 
            // n3
            // 
            n3.BackColor = Color.FromArgb(77, 120, 168);
            n3.CausesValidation = false;
            n3.Cursor = Cursors.Hand;
            n3.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n3.FlatAppearance.BorderSize = 2;
            n3.Font = new Font("Tahoma", 14F);
            n3.ForeColor = SystemColors.Control;
            n3.Location = new Point(123, 261);
            n3.Name = "n3";
            n3.Size = new Size(65, 57);
            n3.TabIndex = 15;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = false;
            n3.Click += button_Click;
            // 
            // n0
            // 
            n0.BackColor = Color.FromArgb(77, 120, 168);
            n0.CausesValidation = false;
            n0.Cursor = Cursors.Hand;
            n0.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            n0.FlatAppearance.BorderSize = 2;
            n0.Font = new Font("Tahoma", 14F);
            n0.ForeColor = SystemColors.Control;
            n0.Location = new Point(2, 315);
            n0.Name = "n0";
            n0.Size = new Size(123, 57);
            n0.TabIndex = 18;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = false;
            n0.Click += button_Click;
            // 
            // dot
            // 
            dot.BackColor = Color.FromArgb(77, 120, 168);
            dot.CausesValidation = false;
            dot.Cursor = Cursors.Hand;
            dot.FlatAppearance.BorderColor = Color.FromArgb(171, 170, 157);
            dot.FlatAppearance.BorderSize = 2;
            dot.Font = new Font("Tahoma", 14F);
            dot.ForeColor = SystemColors.Control;
            dot.Location = new Point(123, 315);
            dot.Name = "dot";
            dot.Size = new Size(62, 57);
            dot.TabIndex = 19;
            dot.Text = ".";
            dot.UseVisualStyleBackColor = false;
            dot.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(71, 97, 94);
            ClientSize = new Size(252, 375);
            Controls.Add(dot);
            Controls.Add(n0);
            Controls.Add(visor);
            Controls.Add(equal);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(n1);
            Controls.Add(subtract);
            Controls.Add(n6);
            Controls.Add(n5);
            Controls.Add(n4);
            Controls.Add(sum);
            Controls.Add(n9);
            Controls.Add(n8);
            Controls.Add(n7);
            Controls.Add(multipli);
            Controls.Add(division);
            Controls.Add(delete);
            Controls.Add(deleteAll);
            Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteAll;
        private Button delete;
        private Button multipli;
        private Button division;
        private Button sum;
        private Button n9;
        private Button n8;
        private Button n7;
        private Button equal;
        private Button subtract;
        private Button n6;
        private Button n5;
        private Button n4;
        private TextBox visor;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button n0;
        private Button dot;
    }
}
