namespace Sem.Zvd.Pr.OOP
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
            this.pnTools = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCircles = new System.Windows.Forms.ComboBox();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.cbCircles);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Location = new System.Drawing.Point(456, 3);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(217, 435);
            this.pnTools.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Location = new System.Drawing.Point(12, 12);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(438, 426);
            this.pnMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // cbCircles
            // 
            this.cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCircles.FormattingEnabled = true;
            this.cbCircles.Location = new System.Drawing.Point(26, 43);
            this.cbCircles.Name = "cbCircles";
            this.cbCircles.Size = new System.Drawing.Size(173, 21);
            this.cbCircles.TabIndex = 1;
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(26, 95);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(173, 23);
            this.btnCreateNew.TabIndex = 2;
            this.btnCreateNew.Text = "Створити новий об\'єкт ";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(26, 124);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(173, 23);
            this.btnHide.TabIndex = 3;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(26, 153);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(173, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(101, 282);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(32, 23);
            this.btnExpand.TabIndex = 5;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(101, 311);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(33, 23);
            this.btnCollapse.TabIndex = 6;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnRightFar
            // 
            this.btnRightFar.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_130519;
            this.btnRightFar.Location = new System.Drawing.Point(177, 300);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(35, 23);
            this.btnRightFar.TabIndex = 14;
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.btnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_125847;
            this.btnRight.Location = new System.Drawing.Point(141, 300);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 23);
            this.btnRight.TabIndex = 13;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_130541;
            this.btnDownFar.Location = new System.Drawing.Point(101, 381);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(33, 36);
            this.btnDownFar.TabIndex = 12;
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.btnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_125506;
            this.btnDown.Location = new System.Drawing.Point(100, 340);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(37, 35);
            this.btnDown.TabIndex = 11;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_130206;
            this.btnLeftFar.Location = new System.Drawing.Point(26, 300);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(32, 23);
            this.btnLeftFar.TabIndex = 10;
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.btnLeftFar_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_130023;
            this.btnLeft.Location = new System.Drawing.Point(64, 300);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 23);
            this.btnLeft.TabIndex = 9;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_130308;
            this.btnUpFar.Location = new System.Drawing.Point(100, 206);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(37, 33);
            this.btnUpFar.TabIndex = 8;
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.btnUpFar_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::Sem.Zvd.Pr.OOP.Properties.Resources.Снимок_экрана_2024_11_18_125319;
            this.btnUp.Location = new System.Drawing.Point(100, 245);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(34, 31);
            this.btnUp.TabIndex = 7;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTools);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circle Class Demo";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.ComboBox cbCircles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightFar;
    }
}

