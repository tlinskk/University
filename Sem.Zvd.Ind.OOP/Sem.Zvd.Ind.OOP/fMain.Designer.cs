namespace Sem.Zvd.Ind.OOP
{
    partial class fMain
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
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmblema = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Right = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnCreateTriangle = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(122, 109);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCircle.TabIndex = 0;
            this.btnCreateCircle.Text = "Create Circle";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmblema);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Right);
            this.panel1.Controls.Add(this.btnDown);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.btnUp);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnCreateTriangle);
            this.panel1.Controls.Add(this.btnCreateCircle);
            this.panel1.Location = new System.Drawing.Point(448, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 438);
            this.panel1.TabIndex = 1;
            // 
            // cmbEmblema
            // 
            this.cmbEmblema.FormattingEnabled = true;
            this.cmbEmblema.Location = new System.Drawing.Point(34, 38);
            this.cmbEmblema.Name = "cmbEmblema";
            this.cmbEmblema.Size = new System.Drawing.Size(121, 21);
            this.cmbEmblema.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Перелік фігур";
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(139, 264);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(75, 23);
            this.Right.TabIndex = 9;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(77, 308);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 8;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(13, 264);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(94, 279);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(39, 23);
            this.btnCollapse.TabIndex = 6;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(94, 250);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(39, 23);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(77, 221);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 4;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(122, 151);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(31, 151);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnCreateTriangle
            // 
            this.btnCreateTriangle.Location = new System.Drawing.Point(15, 109);
            this.btnCreateTriangle.Name = "btnCreateTriangle";
            this.btnCreateTriangle.Size = new System.Drawing.Size(101, 23);
            this.btnCreateTriangle.TabIndex = 1;
            this.btnCreateTriangle.Text = "Create Triangle";
            this.btnCreateTriangle.UseVisualStyleBackColor = true;
            this.btnCreateTriangle.Click += new System.EventHandler(this.btnCreateTriangle_Click);
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(28, 21);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(386, 391);
            this.pnMain.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Name = "fMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCircle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnCreateTriangle;
        private System.Windows.Forms.ComboBox cmbEmblema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Panel pnMain;
    }
}

