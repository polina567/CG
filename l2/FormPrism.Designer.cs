namespace Призма
{
    partial class FormPrism
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxSmooth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownZScale = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYScale = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXScale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownZMove = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYMove = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXMove = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownZRotate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYRotate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXRotate = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXRotate)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.ForeColor = System.Drawing.Color.White;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.picture);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label15);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxSmooth);
            this.splitContainer.Panel2.Controls.Add(this.label9);
            this.splitContainer.Panel2.Controls.Add(this.label8);
            this.splitContainer.Panel2.Controls.Add(this.label7);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownZScale);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownYScale);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownXScale);
            this.splitContainer.Panel2.Controls.Add(this.label6);
            this.splitContainer.Panel2.Controls.Add(this.label5);
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownZMove);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownYMove);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownXMove);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownZRotate);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownYRotate);
            this.splitContainer.Panel2.Controls.Add(this.numericUpDownXRotate);
            this.splitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel2_Paint);
            this.splitContainer.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseClick);
            this.splitContainer.Size = new System.Drawing.Size(1437, 850);
            this.splitContainer.SplitterDistance = 1117;
            this.splitContainer.SplitterWidth = 5;
            this.splitContainer.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(4);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1115, 848);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(61, 348);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 16);
            this.label15.TabIndex = 50;
            this.label15.Text = "Проекция:";
            // 
            // comboBoxSmooth
            // 
            this.comboBoxSmooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSmooth.FormattingEnabled = true;
            this.comboBoxSmooth.Items.AddRange(new object[] {
            "Не задана",
            "Вид спереди",
            "Вид сбоку",
            "Вид сверху",
            "Изометрия"});
            this.comboBoxSmooth.Location = new System.Drawing.Point(144, 345);
            this.comboBoxSmooth.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSmooth.Name = "comboBoxSmooth";
            this.comboBoxSmooth.Size = new System.Drawing.Size(138, 24);
            this.comboBoxSmooth.TabIndex = 49;
            this.comboBoxSmooth.SelectedIndexChanged += new System.EventHandler(this.comboBoxSmooth_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(96, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Масштаб по z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(96, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Масштаб по y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(95, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Масштаб по x:";
            // 
            // numericUpDownZScale
            // 
            this.numericUpDownZScale.DecimalPlaces = 1;
            this.numericUpDownZScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZScale.Location = new System.Drawing.Point(209, 292);
            this.numericUpDownZScale.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownZScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownZScale.Name = "numericUpDownZScale";
            this.numericUpDownZScale.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownZScale.TabIndex = 34;
            this.numericUpDownZScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZScale.ValueChanged += new System.EventHandler(this.numericUpDownZScale_ValueChanged);
            // 
            // numericUpDownYScale
            // 
            this.numericUpDownYScale.DecimalPlaces = 1;
            this.numericUpDownYScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownYScale.Location = new System.Drawing.Point(209, 262);
            this.numericUpDownYScale.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownYScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownYScale.Name = "numericUpDownYScale";
            this.numericUpDownYScale.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownYScale.TabIndex = 33;
            this.numericUpDownYScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYScale.ValueChanged += new System.EventHandler(this.numericUpDownYScale_ValueChanged);
            // 
            // numericUpDownXScale
            // 
            this.numericUpDownXScale.DecimalPlaces = 1;
            this.numericUpDownXScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownXScale.Location = new System.Drawing.Point(209, 228);
            this.numericUpDownXScale.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownXScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownXScale.Name = "numericUpDownXScale";
            this.numericUpDownXScale.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownXScale.TabIndex = 32;
            this.numericUpDownXScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownXScale.ValueChanged += new System.EventHandler(this.numericUpDownXScale_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Перемещение по z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Перемещение по y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Перемещение по x:";
            // 
            // numericUpDownZMove
            // 
            this.numericUpDownZMove.Location = new System.Drawing.Point(211, 185);
            this.numericUpDownZMove.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownZMove.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownZMove.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownZMove.Name = "numericUpDownZMove";
            this.numericUpDownZMove.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownZMove.TabIndex = 28;
            this.numericUpDownZMove.ValueChanged += new System.EventHandler(this.numericUpDownZMove_ValueChanged);
            // 
            // numericUpDownYMove
            // 
            this.numericUpDownYMove.Location = new System.Drawing.Point(211, 151);
            this.numericUpDownYMove.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownYMove.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYMove.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownYMove.Name = "numericUpDownYMove";
            this.numericUpDownYMove.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownYMove.TabIndex = 27;
            this.numericUpDownYMove.ValueChanged += new System.EventHandler(this.numericUpDownYMove_ValueChanged);
            // 
            // numericUpDownXMove
            // 
            this.numericUpDownXMove.Location = new System.Drawing.Point(211, 121);
            this.numericUpDownXMove.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownXMove.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownXMove.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownXMove.Name = "numericUpDownXMove";
            this.numericUpDownXMove.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownXMove.TabIndex = 26;
            this.numericUpDownXMove.ValueChanged += new System.EventHandler(this.numericUpDownXMove_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(61, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Поворот вокруг Oz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Поворот вокруг Oy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Поворот вокруг Ox:";
            // 
            // numericUpDownZRotate
            // 
            this.numericUpDownZRotate.Location = new System.Drawing.Point(209, 78);
            this.numericUpDownZRotate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownZRotate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownZRotate.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownZRotate.Name = "numericUpDownZRotate";
            this.numericUpDownZRotate.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownZRotate.TabIndex = 22;
            this.numericUpDownZRotate.ValueChanged += new System.EventHandler(this.numericUpDownZRotate_ValueChanged);
            // 
            // numericUpDownYRotate
            // 
            this.numericUpDownYRotate.Location = new System.Drawing.Point(209, 46);
            this.numericUpDownYRotate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownYRotate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownYRotate.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownYRotate.Name = "numericUpDownYRotate";
            this.numericUpDownYRotate.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownYRotate.TabIndex = 21;
            this.numericUpDownYRotate.ValueChanged += new System.EventHandler(this.numericUpDownYRotate_ValueChanged);
            // 
            // numericUpDownXRotate
            // 
            this.numericUpDownXRotate.Location = new System.Drawing.Point(209, 14);
            this.numericUpDownXRotate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownXRotate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownXRotate.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownXRotate.Name = "numericUpDownXRotate";
            this.numericUpDownXRotate.Size = new System.Drawing.Size(73, 22);
            this.numericUpDownXRotate.TabIndex = 20;
            this.numericUpDownXRotate.ValueChanged += new System.EventHandler(this.numericUpDownXRotate_ValueChanged);
            // 
            // FormPrism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 850);
            this.Controls.Add(this.splitContainer);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrism";
            this.Text = "Призма";
            this.Load += new System.EventHandler(this.FormPrism_Load);
            this.Shown += new System.EventHandler(this.FormPrism_Shown);
            this.SizeChanged += new System.EventHandler(this.FormPrism_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrism_KeyDown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXRotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownZScale;
        private System.Windows.Forms.NumericUpDown numericUpDownYScale;
        private System.Windows.Forms.NumericUpDown numericUpDownXScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownZMove;
        private System.Windows.Forms.NumericUpDown numericUpDownYMove;
        private System.Windows.Forms.NumericUpDown numericUpDownXMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownZRotate;
        private System.Windows.Forms.NumericUpDown numericUpDownYRotate;
        private System.Windows.Forms.NumericUpDown numericUpDownXRotate;
        private System.Windows.Forms.ComboBox comboBoxSmooth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

