
namespace Racing
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
            this.buttonRace = new System.Windows.Forms.Button();
            this.listBoxChoose = new System.Windows.Forms.ListBox();
            this.listBoxChoosen = new System.Windows.Forms.ListBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelChoose = new System.Windows.Forms.Label();
            this.labelChoosen = new System.Windows.Forms.Label();
            this.labelHelper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRace
            // 
            this.buttonRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRace.Location = new System.Drawing.Point(318, 19);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(146, 50);
            this.buttonRace.TabIndex = 0;
            this.buttonRace.Text = "Create Race";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRace_MouseClick);
            // 
            // listBoxChoose
            // 
            this.listBoxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChoose.FormattingEnabled = true;
            this.listBoxChoose.ItemHeight = 20;
            this.listBoxChoose.Location = new System.Drawing.Point(12, 170);
            this.listBoxChoose.Name = "listBoxChoose";
            this.listBoxChoose.Size = new System.Drawing.Size(300, 264);
            this.listBoxChoose.TabIndex = 1;
            this.listBoxChoose.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxChoose_MouseDoubleClick);
            // 
            // listBoxChoosen
            // 
            this.listBoxChoosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChoosen.FormattingEnabled = true;
            this.listBoxChoosen.ItemHeight = 20;
            this.listBoxChoosen.Location = new System.Drawing.Point(470, 170);
            this.listBoxChoosen.Name = "listBoxChoosen";
            this.listBoxChoosen.Size = new System.Drawing.Size(300, 264);
            this.listBoxChoosen.TabIndex = 2;
            this.listBoxChoosen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxChoosen_MouseDoubleClick);
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDistance.Location = new System.Drawing.Point(7, 90);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(99, 25);
            this.labelDistance.TabIndex = 3;
            this.labelDistance.Text = "Distance: ";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistance.Location = new System.Drawing.Point(96, 87);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(216, 30);
            this.textBoxDistance.TabIndex = 4;
            this.textBoxDistance.Text = "1";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All",
            "Air",
            "Ground"});
            this.comboBoxType.Location = new System.Drawing.Point(533, 84);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(237, 33);
            this.comboBoxType.TabIndex = 5;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(465, 90);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(68, 25);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Type: ";
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoose.Location = new System.Drawing.Point(7, 142);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(162, 25);
            this.labelChoose.TabIndex = 7;
            this.labelChoose.Text = "Choose transport";
            // 
            // labelChoosen
            // 
            this.labelChoosen.AutoSize = true;
            this.labelChoosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChoosen.Location = new System.Drawing.Point(465, 142);
            this.labelChoosen.Name = "labelChoosen";
            this.labelChoosen.Size = new System.Drawing.Size(173, 25);
            this.labelChoosen.TabIndex = 8;
            this.labelChoosen.Text = "Choosen transport";
            // 
            // labelHelper
            // 
            this.labelHelper.AutoSize = true;
            this.labelHelper.Location = new System.Drawing.Point(256, 437);
            this.labelHelper.Name = "labelHelper";
            this.labelHelper.Size = new System.Drawing.Size(277, 17);
            this.labelHelper.TabIndex = 9;
            this.labelHelper.Text = "Click twice to move the racer to another list";
            this.labelHelper.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.labelHelper);
            this.Controls.Add(this.labelChoosen);
            this.Controls.Add(this.labelChoose);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.listBoxChoosen);
            this.Controls.Add(this.listBoxChoose);
            this.Controls.Add(this.buttonRace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void MyFunc()
        {
            int ind = 0;
            foreach (var item in CreateAll())
            {
                listBoxChoose.Items.Insert(ind++, item);
            }
        }

        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.ListBox listBoxChoose;
        private System.Windows.Forms.ListBox listBoxChoosen;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Label labelChoosen;
        private System.Windows.Forms.Label labelHelper;
    }
}

