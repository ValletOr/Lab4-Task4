
namespace Lab4_Task4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listReCreateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cInfBox = new System.Windows.Forms.RichTextBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.RichTextBox();
            this.infBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listReCreateBtn
            // 
            this.listReCreateBtn.Location = new System.Drawing.Point(343, 10);
            this.listReCreateBtn.Name = "listReCreateBtn";
            this.listReCreateBtn.Size = new System.Drawing.Size(113, 68);
            this.listReCreateBtn.TabIndex = 0;
            this.listReCreateBtn.Text = "Пересоздать список";
            this.listReCreateBtn.UseVisualStyleBackColor = true;
            this.listReCreateBtn.Click += new System.EventHandler(this.listReCreateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cInfBox
            // 
            this.cInfBox.Location = new System.Drawing.Point(12, 12);
            this.cInfBox.Name = "cInfBox";
            this.cInfBox.ReadOnly = true;
            this.cInfBox.Size = new System.Drawing.Size(325, 66);
            this.cInfBox.TabIndex = 2;
            this.cInfBox.Text = "";
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(343, 85);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(113, 106);
            this.getBtn.TabIndex = 3;
            this.getBtn.Text = "Взять талон";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(12, 84);
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(325, 107);
            this.outBox.TabIndex = 4;
            this.outBox.Text = "";
            // 
            // infBtn
            // 
            this.infBtn.Location = new System.Drawing.Point(462, 12);
            this.infBtn.Name = "infBtn";
            this.infBtn.Size = new System.Drawing.Size(107, 179);
            this.infBtn.TabIndex = 5;
            this.infBtn.Text = "Описание автомата";
            this.infBtn.UseVisualStyleBackColor = true;
            this.infBtn.Click += new System.EventHandler(this.infBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 467);
            this.Controls.Add(this.infBtn);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.cInfBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listReCreateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Автомат с талонами на транспорт";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listReCreateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox cInfBox;
        private System.Windows.Forms.Button getBtn;
        private System.Windows.Forms.RichTextBox outBox;
        private System.Windows.Forms.Button infBtn;
    }
}

