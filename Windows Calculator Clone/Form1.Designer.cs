namespace Windows_Calculator_Clone
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
            this.neg = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation_show = new System.Windows.Forms.Label();
            this.clear_History = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Label();
            this.memory = new System.Windows.Forms.Label();
            this.no_History = new System.Windows.Forms.Label();
            this.history_Box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // neg
            // 
            this.neg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.neg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.neg.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.neg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neg.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neg.Location = new System.Drawing.Point(3, 570);
            this.neg.Name = "neg";
            this.neg.Size = new System.Drawing.Size(78, 73);
            this.neg.TabIndex = 0;
            this.neg.Text = "⁺/₋";
            this.neg.UseVisualStyleBackColor = false;
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.point.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.point.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(163, 570);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(78, 73);
            this.point.TabIndex = 1;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.num_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zero.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(83, 570);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(78, 73);
            this.zero.TabIndex = 1;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.num_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equals.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equals.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(243, 570);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(78, 73);
            this.equals.TabIndex = 2;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.plus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(243, 495);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 73);
            this.plus.TabIndex = 6;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operator_click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.two.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(83, 495);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(78, 73);
            this.two.TabIndex = 4;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.num_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.three.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(163, 495);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(78, 73);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.num_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(3, 495);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(78, 73);
            this.one.TabIndex = 3;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.num_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.minus.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(243, 420);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(78, 73);
            this.minus.TabIndex = 10;
            this.minus.Text = "−";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operator_click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.five.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.five.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(83, 420);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(78, 73);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.num_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.six.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.six.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(163, 420);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(78, 73);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.num_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.four.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.four.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(3, 420);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(78, 73);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.num_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Wingdings", 13F);
            this.delete.Location = new System.Drawing.Point(243, 195);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(78, 73);
            this.delete.TabIndex = 22;
            this.delete.Text = "";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.clearEntry.FlatAppearance.BorderSize = 0;
            this.clearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearEntry.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.clearEntry.Location = new System.Drawing.Point(83, 195);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(78, 73);
            this.clearEntry.TabIndex = 20;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = false;
            this.clearEntry.Click += new System.EventHandler(this.clearEntry_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.clearAll.Location = new System.Drawing.Point(163, 195);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(78, 73);
            this.clearAll.TabIndex = 21;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.percent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.percent.FlatAppearance.BorderSize = 0;
            this.percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percent.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.percent.Location = new System.Drawing.Point(3, 195);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(78, 73);
            this.percent.TabIndex = 19;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divide.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(243, 270);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(78, 73);
            this.divide.TabIndex = 18;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.operator_click);
            // 
            // square
            // 
            this.square.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.square.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.square.FlatAppearance.BorderSize = 0;
            this.square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.square.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.square.Location = new System.Drawing.Point(83, 270);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(78, 73);
            this.square.TabIndex = 16;
            this.square.Text = "x²";
            this.square.UseVisualStyleBackColor = false;
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.squareRoot.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.squareRoot.FlatAppearance.BorderSize = 0;
            this.squareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareRoot.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.squareRoot.Location = new System.Drawing.Point(163, 270);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(78, 73);
            this.squareRoot.TabIndex = 17;
            this.squareRoot.Text = "²√x";
            this.squareRoot.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button20.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.button20.Location = new System.Drawing.Point(3, 270);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(78, 73);
            this.button20.TabIndex = 15;
            this.button20.Text = "¹/ₓ";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.times.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.times.FlatAppearance.BorderSize = 0;
            this.times.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.times.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.Location = new System.Drawing.Point(243, 345);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(78, 73);
            this.times.TabIndex = 14;
            this.times.Text = "×";
            this.times.UseVisualStyleBackColor = false;
            this.times.Click += new System.EventHandler(this.operator_click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eight.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(83, 345);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(78, 73);
            this.eight.TabIndex = 12;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.num_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(163, 345);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(78, 73);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.num_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seven.Font = new System.Drawing.Font("Segoe UI Semibold", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(3, 345);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(78, 73);
            this.seven.TabIndex = 11;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.num_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(3, 63);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(318, 64);
            this.result.TabIndex = 23;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation_show
            // 
            this.equation_show.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.equation_show.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equation_show.Location = new System.Drawing.Point(3, 40);
            this.equation_show.MinimumSize = new System.Drawing.Size(100, 0);
            this.equation_show.Name = "equation_show";
            this.equation_show.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equation_show.Size = new System.Drawing.Size(318, 29);
            this.equation_show.TabIndex = 24;
            this.equation_show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clear_History
            // 
            this.clear_History.FlatAppearance.BorderSize = 0;
            this.clear_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_History.Font = new System.Drawing.Font("Wingdings 2", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.clear_History.Location = new System.Drawing.Point(522, 607);
            this.clear_History.Name = "clear_History";
            this.clear_History.Size = new System.Drawing.Size(30, 36);
            this.clear_History.TabIndex = 25;
            this.clear_History.Text = "";
            this.clear_History.UseVisualStyleBackColor = true;
            this.clear_History.Click += new System.EventHandler(this.clearhistory_Click);
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.history.Location = new System.Drawing.Point(343, 27);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(64, 21);
            this.history.TabIndex = 26;
            this.history.Text = "History";
            // 
            // memory
            // 
            this.memory.AutoSize = true;
            this.memory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.memory.Location = new System.Drawing.Point(429, 27);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(73, 21);
            this.memory.TabIndex = 27;
            this.memory.Text = "Memory";
            // 
            // no_History
            // 
            this.no_History.AutoSize = true;
            this.no_History.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.no_History.Location = new System.Drawing.Point(327, 75);
            this.no_History.Name = "no_History";
            this.no_History.Size = new System.Drawing.Size(133, 17);
            this.no_History.TabIndex = 28;
            this.no_History.Text = "There\'s no history yet";
            // 
            // history_Box
            // 
            this.history_Box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.history_Box.BackColor = System.Drawing.SystemColors.ControlLight;
            this.history_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.history_Box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_Box.Location = new System.Drawing.Point(325, 94);
            this.history_Box.Name = "history_Box";
            this.history_Box.ReadOnly = true;
            this.history_Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.history_Box.Size = new System.Drawing.Size(225, 516);
            this.history_Box.TabIndex = 30;
            this.history_Box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(553, 646);
            this.Controls.Add(this.history_Box);
            this.Controls.Add(this.no_History);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.history);
            this.Controls.Add(this.clear_History);
            this.Controls.Add(this.equation_show);
            this.Controls.Add(this.result);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.clearEntry);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.square);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.times);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.four);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.point);
            this.Controls.Add(this.neg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(569, 685);
            this.MinimumSize = new System.Drawing.Size(569, 685);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button neg;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation_show;
        private System.Windows.Forms.Button clear_History;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label memory;
        private System.Windows.Forms.Label no_History;
        private System.Windows.Forms.RichTextBox history_Box;
    }
}

